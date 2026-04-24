using ModBusHelper;
using NModbus;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;


namespace Uetm_2_0
{
    public partial class ConfiguratorForm : Form
    {
        private ModBusExporterLinker ExporterLinkerHelper = new ModBusExporterLinker();
        public static ConfiguratorForm CurrentInstance;
        private string userRole;
        private bool settingsExpanded = false;

        // Управление подключением
        private Tuple<TcpClient, IModbusMaster> _connection;
        private string _ip;
        private int _port;

        // Таймер для ConnectionTimeout
        private System.Windows.Forms.Timer connectionTimeoutTimer;

        // События для оповещения UserControl'ов
        public event Action<Tuple<TcpClient, IModbusMaster>> ConnectionStarted;
        public event Action ConnectionStopped;
        public event Action SettingsRead;

        // UserControl'ы для вкладок
        public UcManagement ucManagement;
        public UcGeneral ucGeneral;
        public UcNetwork ucNetwork;
        public UcJournal ucJournal;

        // WinAPI для закрытия MessageBox
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        private const uint WM_CLOSE = 0x0010;

        public ConfiguratorForm(string role)
        {
            userRole = role;
            InitializeComponent();
            Database.GeneralSettings_TextFormat = ExporterLinkerHelper.GeneralSettings_Text_Default;
            Database.Filtered_Journal_Records = ExporterLinkerHelper.journal_record_Default;
            CurrentInstance = this;

            // Устройства уже загружены в статическом конструкторе Database
            RefreshDevicesList();

            ConnectionStarted += OnConnectionStarted;
            ConnectionStopped += OnConnectionStopped;
            SettingsRead += OnSettingsRead;
            this.FormClosing += ConfiguratorForm_FormClosing;

            ucManagement = new UcManagement(this);
            ucGeneral = new UcGeneral(this);
            ucNetwork = new UcNetwork(this);
            ucJournal = new UcJournal(this);

            ApplyRoleRestrictions();
            ShowControl(ucManagement);

            connectionTimeoutTimer = new System.Windows.Forms.Timer();
            connectionTimeoutTimer.Interval = 3000;
            connectionTimeoutTimer.Tick += ConnectionTimeoutTimer_Tick;
        }

        public void OnConnectionRestored(Tuple<TcpClient, IModbusMaster> newConnection)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OnConnectionRestored(newConnection)));
                return;
            }
            _connection = newConnection;
            ConnectionStarted?.Invoke(newConnection);
        }

        private void ApplyRoleRestrictions()
        {
            bool isAdmin = Database.CurrentRole == "Администратор";
            btnWrite.Enabled = isAdmin;
            btnChangePassword.Enabled = isAdmin;   // кнопка смены пароля
        }

        public void SetConnectionParams(string ip, int port)
        {
            _ip = ip;
            _port = port;
        }

        public Tuple<TcpClient, IModbusMaster> GetCurrentConnection() => _connection;

        public void Connect()
        {
            if (string.IsNullOrEmpty(_ip) || !IPAddress.TryParse(_ip, out _))
            {
                MessageBox.Show("IP-адрес не задан или некорректен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_port < 1 || _port > 65535)
            {
                MessageBox.Show("Некорректный порт.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connectionTimeoutTimer.Start();
            try
            {
                _connection = ConnectionManager.OpenConnection(_ip, _port);
                connectionTimeoutTimer.Stop();
                ConnectionStarted?.Invoke(_connection);
                ReadAllSettings();
            }
            catch (TimeoutException ex)
            {
                connectionTimeoutTimer.Stop();
                MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Disconnect();
            }
            catch (Exception ex)
            {
                connectionTimeoutTimer.Stop();
                MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect();
            }
        }

        public void Disconnect()
        {
            try
            {
                if (_connection != null)
                {
                    ConnectionManager.CloseConnection();
                    ConnectionStopped?.Invoke();
                    _connection = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отключении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConnectionTimeoutTimer_Tick(object sender, EventArgs e)
        {
            connectionTimeoutTimer.Stop();
            if (_connection == null || !_connection.Item1.Connected)
            {
                MessageBox.Show("Не удалось подключиться к устройству.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Disconnect();
            }
        }

        private void ReadAllSettings()
        {
            try
            {
                Database.GeneralSettings_TextFormat = ExporterLinkerHelper.get_GeneralSettings_Text(_connection);
                SettingsRead?.Invoke();

                ucGeneral.UpdateFromDatabase();
                ucNetwork.UpdateFromDatabase();

                if (ChildFormPanel.Controls[0] is UcGeneral general)
                    general.UpdateFromDatabase();
                else if (ChildFormPanel.Controls[0] is UcNetwork network)
                    network.UpdateFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения настроек: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshSettings()
        {
            if (_connection?.Item1?.Connected == true)
                ReadAllSettings();
            else
                MessageBox.Show("Нет активного подключения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void OnConnectionStarted(Tuple<TcpClient, IModbusMaster> connection)
        {
            if (InvokeRequired) Invoke(new Action(UpdateAllCards));
            else UpdateAllCards();
        }

        private void OnConnectionStopped()
        {
            if (InvokeRequired) Invoke(new Action(UpdateAllCards));
            else UpdateAllCards();
        }

        private void OnSettingsRead()
        {
            if (_connection?.Item1?.Connected == true)
            {
                var remoteEndPoint = _connection.Item1.Client.RemoteEndPoint as IPEndPoint;
                if (remoteEndPoint != null)
                {
                    string activeIP = remoteEndPoint.Address.ToString();
                    if (activeIP.StartsWith("::ffff:")) activeIP = activeIP.Substring(7);
                    DeviceInfo activeDev = Database.Devices.Find(d => d.IP == activeIP);
                    if (activeDev != null)
                    {
                        activeDev.InstallationPlace = Database.GeneralSettings_TextFormat.cmns.MntPlce ?? "";
                        activeDev.SwitchLabel = Database.GeneralSettings_TextFormat.swrcs.swnf.label ?? "";
                        Database.SaveAppData();
                        if (InvokeRequired) Invoke(new Action(() => UpdateDeviceCard(activeDev)));
                        else UpdateDeviceCard(activeDev);
                    }
                }
            }
        }

        public void RefreshDevicesList()
        {
            if (InvokeRequired) { Invoke(new Action(RefreshDevicesList)); return; }

            devicesPanel.Controls.Clear();
            devicesPanel.RowCount = 0;
            devicesPanel.RowStyles.Clear();

            foreach (var dev in Database.Devices)
            {
                var card = CreateDeviceCard(dev);
                card.Anchor = AnchorStyles.None;
                card.Margin = new Padding(5);

                devicesPanel.RowCount++;
                devicesPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                devicesPanel.Controls.Add(card, 0, devicesPanel.RowCount - 1);
            }

            devicesPanel.RowCount++;
            devicesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            devicesPanel.Controls.Add(new Control(), 0, devicesPanel.RowCount - 1);
        }

        private DeviceCard CreateDeviceCard(DeviceInfo dev)
        {
            var card = new DeviceCard();
            bool isActive = IsDeviceActive(dev);
            card.SetData(dev.IP, dev.InstallationPlace, dev.SwitchLabel, isActive);
            card.Tag = dev;
            card.DeleteClicked += (s, e) => BtnDelete_Click(dev);
            card.ConnectClicked += (s, e) => BtnConnect_Click(dev);
            return card;
        }

        private bool IsDeviceActive(DeviceInfo dev)
        {
            if (_connection?.Item1?.Connected == true)
            {
                var remoteEndPoint = _connection.Item1.Client.RemoteEndPoint as IPEndPoint;
                if (remoteEndPoint != null)
                {
                    string remoteIP = remoteEndPoint.Address.ToString();
                    if (remoteIP.StartsWith("::ffff:")) remoteIP = remoteIP.Substring(7);
                    return remoteIP == dev.IP;
                }
            }
            return false;
        }

        private void UpdateAllCards()
        {
            string activeIP = null;
            if (_connection?.Item1?.Connected == true)
            {
                var remoteEndPoint = _connection.Item1.Client.RemoteEndPoint as IPEndPoint;
                if (remoteEndPoint != null)
                {
                    activeIP = remoteEndPoint.Address.ToString();
                    if (activeIP.StartsWith("::ffff:")) activeIP = activeIP.Substring(7);
                }
            }
            foreach (Control c in devicesPanel.Controls)
            {
                if (c is DeviceCard card && card.Tag is DeviceInfo dev)
                {
                    bool isActive = (dev.IP == activeIP);
                    card.SetData(dev.IP, dev.InstallationPlace, dev.SwitchLabel, isActive);
                }
            }
        }

        private void UpdateDeviceCard(DeviceInfo dev)
        {
            foreach (Control c in devicesPanel.Controls)
            {
                if (c is DeviceCard card && card.Tag is DeviceInfo d && d.IP == dev.IP)
                {
                    bool isActive = IsDeviceActive(dev);
                    card.SetData(dev.IP, dev.InstallationPlace, dev.SwitchLabel, isActive);
                    break;
                }
            }
        }

        private void BtnDelete_Click(DeviceInfo dev)
        {
            if (dev == null) return;
            if (MessageBox.Show($"Удалить устройство {dev.IP}?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (IsDeviceActive(dev)) Disconnect();
                Database.Devices.Remove(dev);
                Database.SaveAppData();     // сохраняем изменения в базу
                RefreshDevicesList();
            }
        }

        private void BtnConnect_Click(DeviceInfo dev)
        {
            if (IsDeviceActive(dev)) { Disconnect(); return; }
            if (_connection?.Item1?.Connected == true) Disconnect();
            SetConnectionParams(dev.IP, dev.Port);
            Connect();
        }

        private void ShowControl(UserControl control)
        {
            ChildFormPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(control);
        }

        private void BtnManagement_Click(object sender, EventArgs e) => ShowControl(ucManagement);
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            settingsExpanded = !settingsExpanded;
            btnGeneral.Visible = settingsExpanded;
            btnNetwork.Visible = settingsExpanded;
            btnSettings.Text = settingsExpanded ? "Настройки -" : "Настройки +";
        }
        private void BtnGeneral_Click(object sender, EventArgs e) => ShowControl(ucGeneral);
        private void BtnNetwork_Click(object sender, EventArgs e) => ShowControl(ucNetwork);
        private void BtnJournal_Click(object sender, EventArgs e) => ShowControl(ucJournal);

        private void CloseMessageBox(string caption)
        {
            IntPtr hWnd = FindWindow(null, caption);
            if (hWnd != IntPtr.Zero)
                PostMessage(hWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }

        private async void BtnWrite_Click(object sender, EventArgs e)
        {
            // 1. Проверка прав
            if (Database.CurrentRole != "Администратор")
            {
                MessageBox.Show("Требуются права администратора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Проверка соединения
            if (_connection?.Item1?.Connected != true)
            {
                MessageBox.Show("Нет подключения к устройству.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Подтверждение
            if (MessageBox.Show("Вы уверены, что хотите записать настройки в устройство? После записи устройство перезагрузится, соединение будет разорвано.",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            // 4. Определяем текущее устройство (для возможного обновления IP после записи)
            DeviceInfo activeDev = null;
            string oldIp = _ip;
            if (_connection?.Item1?.Connected == true)
            {
                var remoteEndPoint = _connection.Item1.Client.RemoteEndPoint as IPEndPoint;
                if (remoteEndPoint != null)
                {
                    string remoteIP = remoteEndPoint.Address.ToString();
                    if (remoteIP.StartsWith("::ffff:"))
                        remoteIP = remoteIP.Substring(7);
                    activeDev = Database.Devices.Find(d => d.IP == remoteIP);
                }
            }

            // 5. Сохраняем данные из активной вкладки в Database.GeneralSettings_TextFormat
            if (ChildFormPanel.Controls[0] is UcGeneral general)
            {
                if (!general.SaveToDatabase()) return;
            }
            else if (ChildFormPanel.Controls[0] is UcNetwork network)
            {
                if (!network.SaveToDatabase()) return;
            }

            btnWrite.Enabled = false;
            var connection = _connection;

            // 6. Захват показателей ДО начала записи (пока фоновый опрос активен)
            float? capturedCurrentA = null;
            float? capturedResource = null;
            string capturedPhase = null;
            string capturedDeviceIP = _ip;   // IP, на который выполняется запись

            try
            {
                var rmsTable = ucManagement.GetRmsDataTable();
                var cntvTable = ucManagement.GetCntvDataTable();
                if (rmsTable.Rows.Count > 0)
                {
                    capturedCurrentA = Convert.ToSingle(rmsTable.Rows[0][1]);   // фаза A
                    capturedPhase = rmsTable.Rows[0][0].ToString();             // "A"
                }
                if (cntvTable.Rows.Count > 0)
                    capturedResource = Convert.ToSingle(cntvTable.Rows[0][1]);  // ресурс фазы A
            }
            catch { /* если данные недоступны, останутся null */ }

            // 7. Запускаем сообщение-ожидание в отдельном потоке
            string waitCaption = "Применение настроек";
            var msgThread = new Thread(() => MessageBox.Show(
                "Идёт запись настроек и перезагрузка устройства. Пожалуйста, подождите...",
                waitCaption, MessageBoxButtons.OK, MessageBoxIcon.Information))
            { IsBackground = true };
            msgThread.Start();

            try
            {
                // 8. Выполняем запись в фоне
                await Task.Run(() =>
                    ExporterLinkerHelper.WriteSettings(Database.GeneralSettings_TextFormat, true, connection));

                // 9. Закрываем сообщение-ожидание
                CloseMessageBox(waitCaption);
            }
            catch (Exception ex)
            {
                // 10. Обработка ошибок во время записи
                CloseMessageBox(waitCaption);
                Disconnect();
                btnWrite.Enabled = true;

                if (IsConnectionError(ex))
                    MessageBox.Show("Соединение с устройством потеряно во время записи. Возможно, устройство перезагрузилось.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show($"Ошибка записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                RefreshDevicesList();
                return;
            }
            finally
            {
                // 11. Отключаемся и ждём завершения фонового потока
                Disconnect();
                await Task.Delay(300);
                btnWrite.Enabled = true;
            }

            // 12. Обновляем IP устройства в локальном списке, если он изменился
            string newIp = null;
            if (Database.GeneralSettings_TextFormat.nets.ips.ipAddr != null &&
                Database.GeneralSettings_TextFormat.nets.ips.ipAddr.Length >= 4)
            {
                newIp = $"{Database.GeneralSettings_TextFormat.nets.ips.ipAddr[0]}." +
                        $"{Database.GeneralSettings_TextFormat.nets.ips.ipAddr[1]}." +
                        $"{Database.GeneralSettings_TextFormat.nets.ips.ipAddr[2]}." +
                        $"{Database.GeneralSettings_TextFormat.nets.ips.ipAddr[3]}";
            }

            if (activeDev != null && !string.IsNullOrEmpty(newIp) && oldIp != newIp)
            {
                activeDev.IP = newIp;
                Database.SaveAppData();
            }

            // 13. Запись в журнал изменений (с захваченными ДО записи показателями)
            LocalDatabase.AddLogEntry(
                Database.CurrentRole,
                "Изменение настроек",
                deviceIP: capturedDeviceIP,
                currentA: capturedCurrentA,
                resourcePercent: capturedResource,
                channel: capturedPhase
            );

            // 14. Информируем пользователя о результате
            if (ExporterLinkerHelper.WasRebootCommandSent)
            {
                MessageBox.Show("Настройки успешно записаны. Устройство перезагружается. " +
                                "Подождите несколько секунд и подключитесь заново.",
                                "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Настройки записаны в буфер, но команда перезагрузки не была подтверждена. " +
                                "Возможно, потребуется перезагрузить устройство вручную.",
                                "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            RefreshDevicesList();
            btnWrite.Enabled = true;
        }

        // Смена пароля
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (Database.CurrentRole != "Администратор")
            {
                MessageBox.Show("Только администратор может менять пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dlg = new ChangePasswordDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                if (!AppData.VerifyPassword("Администратор", dlg.CurrentPassword, Database.AppData))
                {
                    MessageBox.Show("Неверный текущий пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Database.AppData.Passwords["Администратор"] = dlg.NewPassword;
                Database.SaveAppData();

                // запись в локальный журнал удалена

                MessageBox.Show("Пароль администратора изменён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsConnectionError(Exception ex)
        {
            string msg = ex.Message.ToLower();
            return msg.Contains("socket") ||
                   msg.Contains("connection") ||
                   msg.Contains("disconnected") ||
                   msg.Contains("transport") ||
                   (ex.InnerException != null && IsConnectionError(ex.InnerException));
        }

        private void ConfiguratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
            Database.SaveAppData();
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            string info = "АО «Уралэлектротяжмаш»\nАдрес: ул. Фронтовых бригад, 22, Екатеринбург\nВерсия: 2.0";
            MessageBox.Show(info, "О предприятии", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UserHelp_Click(object sender, EventArgs e)
        {
            string info =
                "Порядок работы:\n" +
                "1. Управление - ввод IP и порта (502) - Добавить - Подключиться.\n" +
                "2. Подключиться – загрузка настроек с устройства.\n" +
                "3. Записать – отправка настроек (требует подтверждения).\n" +
                "\nОграничения:\n" +
                "- Токи: целые числа в пределах, указанных в ошибках.\n" +
                "- Коэффициенты C1-C4: ввод с точкой (дробная часть).\n" +
                "- Установка времени недоступна при PTP-синхронизации.\n" +
                "- При изменении данных устройство перезагружается, соединение рвётся.\n" +
                "\nЖурнал:\n" +
                "- Обновить – чтение с устройства, Экспорт в EXCEL.\n" +
                "\nКоманды для администратора:\n" +
                "- Очистить ресурс, Установить время, Перезагрузить.\n" +
                "\nПрочее:\n" +
                "- Таймаут подключения, перезагрузки несколько секунд сек.\n" +
                "- Список устройств и настройки хранятся в файле config.db (LiteDB).";

            MessageBox.Show(info, "Руководство", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}