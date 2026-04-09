using ModBusHelper;
using NModbus;
using System.Net;
using System.Net.Sockets;

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

        // События для оповещения UserControl'ов
        public event Action<Tuple<TcpClient, IModbusMaster>> ConnectionStarted;
        public event Action ConnectionStopped;
        public event Action SettingsRead;

        // UserControl'ы для вкладок
        public UcManagement ucManagement;
        public UcGeneral ucGeneral;
        public UcNetwork ucNetwork;
        public UcJournal ucJournal;

        // Элементы интерфейса (создаются в дизайнере)
        private FlowLayoutPanel Sidebar;
        private Button btnManagement;
        private Button btnSettings;
        private Button btnGeneral;
        private Button btnNetwork;
        private Button btnJournal;
        private Panel topPanel;
        private Button btnRead;
        private Button btnWrite;
        private Panel rightPanel;
        private FlowLayoutPanel devicesPanel;

        private System.Windows.Forms.Timer connectionTimeoutTimer;

        public ConfiguratorForm(string role)
        {
            userRole = role;
            InitializeComponent();
            Database.GeneralSettings_TextFormat = ExporterLinkerHelper.GeneralSettings_Text_Default;
            Database.Filtered_Journal_Records = ExporterLinkerHelper.journal_record_Default;
            CurrentInstance = this;

            Database.LoadDevices();
            RefreshDevicesList();

            // Подписка на собственные события для обновления UI
            ConnectionStarted += OnConnectionStarted;
            ConnectionStopped += OnConnectionStopped;
            SettingsRead += OnSettingsRead;

            this.FormClosing += ConfiguratorForm_FormClosing;

            // Создание UserControl'ов с передачей ссылки на текущую форму
            ucManagement = new UcManagement(this);
            ucGeneral = new UcGeneral(this);
            ucNetwork = new UcNetwork(this);
            ucJournal = new UcJournal(this);

            // Применяем ограничения ролей
            ApplyRoleRestrictions();


            // Показываем страницу управления по умолчанию
            ShowControl(ucManagement);


            connectionTimeoutTimer = new System.Windows.Forms.Timer();
            connectionTimeoutTimer.Interval = 5000; // 5 секунд
            connectionTimeoutTimer.Tick += ConnectionTimeoutTimer_Tick;
        }


        // Метод для таймаута:
        private void ConnectionTimeoutTimer_Tick(object sender, EventArgs e)
        {
            connectionTimeoutTimer.Stop();
            if (_connection == null || !_connection.Item1.Connected)
            {
                MessageBox.Show("Не удалось подключиться к устройству в течение 5 секунд.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Disconnect();
            }
        }

        private void ApplyRoleRestrictions()
        {
            bool isAdmin = Database.CurrentRole == "Администратор";
            btnWrite.Enabled = isAdmin; // кнопка "Записать" активна только для администратора
        }

        // ==================== Управление подключением ====================

        public void SetConnectionParams(string ip, int port)
        {
            _ip = ip;
            _port = port;
        }

        public Tuple<TcpClient, IModbusMaster> GetCurrentConnection()
        {
            return _connection;
        }

        public void Connect()
        {
            if (string.IsNullOrEmpty(_ip) || !IPAddress.TryParse(_ip, out _))
            {
                MessageBox.Show("IP-адрес не задан или некорректен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_port < 1 || _port > 1000)
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

        private void ReadAllSettings()
        {
            try
            {
                Database.GeneralSettings_TextFormat = ExporterLinkerHelper.get_GeneralSettings_Text(_connection);
                SettingsRead?.Invoke();
                // Обновляем текущий контрол, если он поддерживает обновление
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
            {
                ReadAllSettings();
            }
            else
            {
                MessageBox.Show("Нет активного подключения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==================== Обработчики событий ====================

        private void OnConnectionStarted(Tuple<TcpClient, IModbusMaster> connection)
        {
            if (InvokeRequired)
                Invoke(new Action(UpdateAllCards));
            else
                UpdateAllCards();
        }

        private void OnConnectionStopped()
        {
            if (InvokeRequired)
                Invoke(new Action(UpdateAllCards));
            else
                UpdateAllCards();
        }

        private void OnSettingsRead()
        {
            if (_connection?.Item1?.Connected == true)
            {
                var remoteEndPoint = _connection.Item1.Client.RemoteEndPoint as IPEndPoint;
                if (remoteEndPoint != null)
                {
                    string activeIP = remoteEndPoint.Address.ToString();
                    if (activeIP.StartsWith("::ffff:"))
                        activeIP = activeIP.Substring(7);

                    DeviceInfo activeDev = Database.Devices.Find(d => d.IP == activeIP);
                    if (activeDev != null)
                    {
                        activeDev.InstallationPlace = Database.GeneralSettings_TextFormat.cmns.MntPlce ?? "-";
                        activeDev.SwitchLabel = Database.GeneralSettings_TextFormat.swrcs.swnf.label ?? "-";
                        Database.SaveDevices();
                        if (InvokeRequired)
                            Invoke(new Action(() => UpdateDeviceCard(activeDev)));
                        else
                            UpdateDeviceCard(activeDev);
                    }
                }
            }
        }

        // ==================== Работа с карточками устройств ====================

        public void RefreshDevicesList()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(RefreshDevicesList));
                return;
            }
            devicesPanel.Controls.Clear();
            foreach (var dev in Database.Devices)
            {
                var card = CreateDeviceCard(dev);
                devicesPanel.Controls.Add(card);
            }
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
                    if (remoteIP.StartsWith("::ffff:"))
                        remoteIP = remoteIP.Substring(7);
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
                    if (activeIP.StartsWith("::ffff:"))
                        activeIP = activeIP.Substring(7);
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
                if (IsDeviceActive(dev))
                    Disconnect();
                Database.Devices.Remove(dev);
                Database.SaveDevices();
                RefreshDevicesList();
            }
        }

        private void BtnConnect_Click(DeviceInfo dev)
        {
            if (IsDeviceActive(dev))
            {
                Disconnect();
                return;
            }

            if (_connection?.Item1?.Connected == true)
                Disconnect();

            SetConnectionParams(dev.IP, dev.Port);
            Connect();
        }



        // ==================== Навигация и отображение ====================

        private void ShowControl(UserControl control)
        {
            ChildFormPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(control);
        }

        private void BtnManagement_Click(object sender, EventArgs e)
        {
            ShowControl(ucManagement);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            settingsExpanded = !settingsExpanded;
            btnGeneral.Visible = settingsExpanded;
            btnNetwork.Visible = settingsExpanded;
            btnSettings.Text = settingsExpanded ? "Настройки -" : "Настройки +";
        }

        private void BtnGeneral_Click(object sender, EventArgs e)
        {
            ShowControl(ucGeneral);
        }

        private void BtnNetwork_Click(object sender, EventArgs e)
        {
            ShowControl(ucNetwork);
        }

        private void BtnJournal_Click(object sender, EventArgs e)
        {
            ShowControl(ucJournal);
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            if (_connection?.Item1?.Connected != true)
            {
                MessageBox.Show("Нет подключения к устройству.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Database.GeneralSettings_TextFormat = ExporterLinkerHelper.get_GeneralSettings_Text(_connection);
                // Обновляем все контролы, чтобы при переключении на них были свежие данные
                ucGeneral.UpdateFromDatabase();
                ucNetwork.UpdateFromDatabase();
                // UcManagement обновляется по таймеру, его не нужно
                MessageBox.Show("Настройки считаны.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            if (Database.CurrentRole != "Администратор")
            {
                MessageBox.Show("Требуются права администратора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_connection?.Item1?.Connected != true)
            {
                MessageBox.Show("Нет подключения к устройству.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Подтверждение записи
            if (MessageBox.Show("Вы уверены, что хотите записать настройки в устройство?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                if (ChildFormPanel.Controls[0] is UcGeneral general)
                    if (!general.SaveToDatabase()) return;
                    else if (ChildFormPanel.Controls[0] is UcNetwork network)
                        network.SaveToDatabase();

                ExporterLinkerHelper.WriteSettings(Database.GeneralSettings_TextFormat, true, _connection);
                MessageBox.Show("Настройки записаны.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== Закрытие формы ====================

        private void ConfiguratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
            Database.SaveDevices();
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            string info = "АО «Уралэлектротяжмаш»\n" + "Адрес: ул. Фронтовых бригад, 22, Екатеринбург, Свердловская обл.\n" + "Версия программы: 2.0";
            MessageBox.Show(info, "О предприятии", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UserHelp_Click(object sender, EventArgs e)
        {
            string info =
        "1. Управление → ввод IP и порта (502) → Добавить → Подключиться.\n" +
        "2. Считать – загрузка настроек с устройства.\n" +
        "3. Записать – отправка настроек (требует подтверждения).\n" +
        "\nОграничения:\n" +
        "- Токи: целые числа в пределах, указанных в документации.\n" +
        "- Коэффициенты C1-C4: ввод с точкой (дробная часть).\n" +
        "- Установка времени недоступна при PTP-синхронизации.\n" +
        "- При изменении IP/MAC устройство перезагружается, соединение рвётся.\n" +
        "\nЖурнал:\n" +
        "- Обновить – чтение с устройства, Экспорт – CSV.\n" +
        "\nКоманды (админ):\n" +
        "- Обнулить ресурс, Установить время, Перезагрузить.\n" +
        "\nПрочее:\n" +
        "- Таймаут подключения 5 сек.\n" +
        "- Список устройств хранится в devices.json (рядом с exe).";

            MessageBox.Show(info, "Руководство", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}