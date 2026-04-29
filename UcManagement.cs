using ModBusHelper;
using NModbus;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Net;
using System.Net.Sockets;

namespace Uetm_2_0
{
    public partial class UcManagement : UserControl
    {
        private ConfiguratorForm mainForm;
        private BackgroundWorker backgroundWorker;
        private DataTable rmsTable;
        private DataTable cntvTable;
        private ModBusProfile profileHelper = new ModBusProfile();
        private ModBusCommands commandsHelper = new ModBusCommands();
        private Tuple<TcpClient, IModbusMaster> _connection;
        private string _lastIp = "";
        private bool _manualTimeSet = false;
        private float _inom1 = 1.0f; // для пересчёта тока

        public UcManagement(ConfiguratorForm mainForm)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.mainForm = mainForm;
            InitializeDataTables();
            InitializeBackgroundWorker();

            mainForm.ConnectionStarted += OnConnectionStarted;
            mainForm.ConnectionStopped += OnConnectionStopped;

            ipTextBox.Text = _lastIp;

            var existingConnection = mainForm.GetCurrentConnection();
            if (existingConnection != null && existingConnection.Item1.Connected)
            {
                OnConnectionStarted(existingConnection);
            }
        }

        private void InitializeDataTables()
        {
            rmsTable = new DataTable();
            rmsTable.Columns.Add("Канал", typeof(string));
            rmsTable.Columns.Add("Значение (А)", typeof(float));
            rmsDataGridView.DataSource = rmsTable;
            rmsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rmsDataGridView.RowHeadersVisible = false;
            rmsDataGridView.ReadOnly = true;
            rmsDataGridView.Columns[1].DefaultCellStyle.Format = "0.00";
            rmsDataGridView.DataError += (s, e) => e.ThrowException = false;

            cntvTable = new DataTable();
            cntvTable.Columns.Add("Канал", typeof(string));
            cntvTable.Columns.Add("Выработанный ресурс (%)", typeof(float));
            cntvTable.Columns.Add("Количество отключений", typeof(int));
            cntvTable.Columns.Add("Количество включений", typeof(int));
            cntvDataGridView.DataSource = cntvTable;
            cntvDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cntvDataGridView.RowHeadersVisible = false;
            cntvDataGridView.ReadOnly = true;
            cntvDataGridView.Columns[1].DefaultCellStyle.Format = "0.00";
            cntvDataGridView.DataError += (s, e) => e.ThrowException = false;
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
        }

        private void OnConnectionStarted(Tuple<TcpClient, IModbusMaster> connection)
        {
            _connection = connection;
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync(_connection);
            }
        }

        private void OnConnectionStopped()
        {
            _manualTimeSet = false;
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
            SafeInvoke(() =>
            {
                rmsTable.Rows.Clear();
                cntvTable.Rows.Clear();
                deviceStatusLabel.Text = "";
                syncStatusLabel.Text = "";
                rtcStatusLabel.Text = "";
                deviceTimeLabel.Text = "";
                serialNumberLabel.Text = "";
                firmwareVersionLabel.Text = "";
            });
        }

        private bool IsConnectionError(Exception ex)
        {
            if (ex == null) return false;
            string msg = ex.Message.ToLower();
            return msg.Contains("socket") ||
                   msg.Contains("connection") ||
                   msg.Contains("disconnected") ||
                   msg.Contains("transport") ||
                   msg.Contains("disposed") ||
                   msg.Contains("timeout") ||
                   (ex.InnerException != null && IsConnectionError(ex.InnerException));
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var connection = e.Argument as Tuple<TcpClient, IModbusMaster>;
            if (connection == null) return;

            TcpClient tcpClient = connection.Item1;
            IModbusMaster modbusMaster = connection.Item2;
            string deviceIP = null;
            if (tcpClient?.Client?.RemoteEndPoint is IPEndPoint ep)
            {
                deviceIP = ep.Address.ToString();
                if (deviceIP.StartsWith("::ffff:")) deviceIP = deviceIP.Substring(7);
            }

            while (!backgroundWorker.CancellationPending)
            {
                if (tcpClient == null || !tcpClient.Connected)
                {
                    SafeInvoke(() => mainForm.Disconnect());
                    break;
                }

                try
                {
                    var esp = profileHelper.ect_state_page_Read(modbusMaster);
                    var ssp = profileHelper.swrct_state_page_Read(modbusMaster);
                    var timeData = profileHelper.time_Read(modbusMaster);
                    DateTime dt = PtpTimeHelper.PtpToDateTime(timeData.ptpval.ns, timeData.ptpval.slo, timeData.ptsecHi);
                    var cmns = profileHelper.cmns_Read(modbusMaster);

                    // Вычисляем Inom1 для пересчёта тока (единожды или при изменении)
                    float inom1 = 1.0f;
                    string inom1Str = Database.GeneralSettings_TextFormat.meas.primct.Inom1;
                    if (!string.IsNullOrEmpty(inom1Str))
                        float.TryParse(inom1Str, NumberStyles.Any, CultureInfo.InvariantCulture, out inom1);
                    _inom1 = inom1;

                    SafeInvoke(() =>
                    {
                        UpdateRmsTable(esp.rms);
                        UpdateCntvTable(ssp.cntv);
                        UpdateStatus(esp.ste);
                        UpdateRtcStatus(ssp.ste[2]);
                        if (!_manualTimeSet)
                            deviceTimeLabel.Text = dt.ToString("dd.MM.yyyy HH:mm:ss");
                        serialNumberLabel.Text = cmns.SerialNo.ToString();
                        firmwareVersionLabel.Text = cmns.FmwVer.ToString();
                    });

                    // Автоматическое сохранение состояния в локальную БД не выполняется.
                    // Состояние сохраняется только по явной кнопке «Сохранить состояние» (если добавлена).

                    System.Threading.Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    if (IsConnectionError(ex))
                    {
                        SafeInvoke(() => mainForm.Disconnect());
                        break;
                    }
                    else
                    {
                        SafeInvoke(() => MessageBox.Show($"Ошибка чтения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error));
                        SafeInvoke(() => mainForm.Disconnect());
                        break;
                    }
                }
            }
        }

        private void UpdateRmsTable(float[] rms)
        {
            rmsTable.Rows.Clear();
            // Пропускаем индекс 0 (N), отображаем только A(1), B(2), C(3)
            string[] labels = { "A", "B", "C" };
            for (int i = 0; i < labels.Length; i++)
            {
                int deviceIndex = i + 1; // 1,2,3
                if (deviceIndex < rms.Length)
                {
                    float current = (float)Math.Sqrt(Math.Max(0, rms[deviceIndex])) * _inom1;
                    rmsTable.Rows.Add(labels[i], current);
                }
            }
        }

        private void UpdateCntvTable(ModBusProfile.SWCNT[] cntv)
        {
            cntvTable.Rows.Clear();
            string[] labels = { "A", "B", "C" };
            for (int i = 0; i < labels.Length; i++)
            {
                int deviceIndex = i + 1; // A=1, B=2, C=3
                if (deviceIndex < cntv.Length)
                {
                    cntvTable.Rows.Add(labels[i], cntv[deviceIndex].Racc, cntv[deviceIndex].ofcnt, cntv[deviceIndex].oNacnt);
                }
            }
        }

        private void UpdateStatus(byte[] ste)
        {
            deviceStatusLabel.Text = (ste.Length > 0 && ste[0] == 0) ? "В работе" : "Ошибка";
            if (ste.Length > 1)
                syncStatusLabel.Text = ste[1] switch
                {
                    0 => "Не синхронизированы",
                    1 => "Грубая",
                    2 => "Точная",
                    _ => "Неизвестно"
                };
        }

        private void UpdateRtcStatus(byte rtcSte) => rtcStatusLabel.Text = rtcSte == 0 ? "Работают" : "Ошибка";

        private void SafeInvoke(Action action)
        {
            if (this.IsDisposed || this.Disposing) return;
            if (InvokeRequired) Invoke(action);
            else action();
        }

        // ======================= Кнопки управления =======================

        private void AddDeviceButton_Click(object sender, EventArgs e)
        {
            string ip = ipTextBox.Text.Trim();
            if (!IPAddress.TryParse(ip, out _))
            {
                MessageBox.Show("Некорректный IP адрес.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int port;
            if (!int.TryParse(portTextBox.Text, out port) || port < 1 || port > 65535)
            {
                MessageBox.Show("Некорректный порт (1–65535).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Database.Devices.Exists(d => d.IP == ip))
            {
                MessageBox.Show("Устройство с таким IP уже есть в списке.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _lastIp = ip;

            var newDev = new DeviceInfo
            {
                IP = ip,
                Port = port,
                InstallationPlace = "",
                SwitchLabel = ""
            };
            Database.Devices.Add(newDev);
            Database.SaveAppData();

            // запись в локальный журнал удалена

            mainForm.RefreshDevicesList();
            portTextBox.Text = "";
        }

        private void ClearResourceButton_Click(object sender, EventArgs e)
        {
            if (Database.CurrentRole != "Администратор")
            {
                MessageBox.Show("Требуются права администратора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Обнулить счётчик ресурса выключателя?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            var conn = mainForm.GetCurrentConnection();
            if (conn?.Item1?.Connected == true)
            {
                try
                {
                    var response = commandsHelper.nulify_swrc(conn.Item2);
                    if (response.Data[0] == 0xFF)
                        MessageBox.Show("Счётчик ресурса обнулён.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ошибка обнуления счётчика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Нет подключения к устройству.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetTimeButton_Click(object sender, EventArgs e)
        {
            if (Database.CurrentRole != "Администратор")
            {
                MessageBox.Show("Требуются права администратора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conn = mainForm.GetCurrentConnection();
            if (conn?.Item1?.Connected != true)
            {
                MessageBox.Show("Нет подключения к устройству.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var esp = profileHelper.ect_state_page_Read(conn.Item2);
                if (esp.ste.Length > 1 && esp.ste[1] != 0)
                {
                    MessageBox.Show("Невозможно изменить время – устройство синхронизировано с PTP мастером.",
                        "Операция запрещена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка проверки синхронизации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var dialog = new SetTimeDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        (uint ns, uint slo, ushort ptsecHi) = PtpTimeHelper.DateTimeToPtp(dialog.SelectedDateTime);
                        ushort[] registers = new ushort[6];
                        registers[0] = (ushort)((ns >> 16) & 0xFFFF);
                        registers[1] = (ushort)(ns & 0xFFFF);
                        registers[2] = (ushort)((slo >> 16) & 0xFFFF);
                        registers[3] = (ushort)(slo & 0xFFFF);
                        registers[4] = ptsecHi;
                        registers[5] = 0;

                        conn.Item2.WriteMultipleRegisters(0, 2816, registers);
                        System.Threading.Thread.Sleep(200);

                        var commands = new ModBusCommands();
                        commands.upload_settings(conn.Item2, 0x0100);

                        SafeInvoke(() => deviceTimeLabel.Text = dialog.SelectedDateTime.ToString("dd.MM.yyyy HH:mm:ss"));
                        mainForm.Disconnect();
                        mainForm.RefreshDevicesList();

                        MessageBox.Show("Время установлено. Устройство перезагружается. Подождите несколько секунд и подключитесь заново.",
                            "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        if (IsConnectionError(ex))
                        {
                            SafeInvoke(() => deviceTimeLabel.Text = dialog.SelectedDateTime.ToString("dd.MM.yyyy HH:mm:ss"));
                            mainForm.Disconnect();
                            mainForm.RefreshDevicesList();
                            MessageBox.Show("Время установлено. Устройство перезагружается.",
                                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Ошибка установки времени: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void RebootButton_Click(object sender, EventArgs e)
        {
            if (Database.CurrentRole != "Администратор")
            {
                MessageBox.Show("Требуются права администратора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Перезагрузить устройство? Соединение будет разорвано.", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            var conn = mainForm.GetCurrentConnection();
            if (conn?.Item1?.Connected == true)
            {
                try
                {
                    var response = commandsHelper.reset_ect(conn.Item2);
                    if (response.Data[0] == 0xFF)
                    {
                        MessageBox.Show("Устройство перезагружается.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainForm.Disconnect();
                        mainForm.RefreshDevicesList();
                    }
                    else
                        MessageBox.Show("Ошибка перезагрузки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    if (IsConnectionError(ex))
                    {
                        MessageBox.Show("Устройство перезагружается.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainForm.Disconnect();
                        mainForm.RefreshDevicesList();
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет подключения к устройству.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Публичные свойства для экспорта в Excel
        public DataTable GetRmsDataTable() => rmsTable;
        public DataTable GetCntvDataTable() => cntvTable;
        public string GetDeviceStatusText() => deviceStatusLabel.Text;
        public string GetSyncStatusText() => syncStatusLabel.Text;
        public string GetRtcStatusText() => rtcStatusLabel.Text;
        public string GetDeviceTimeText() => deviceTimeLabel.Text;
        public string GetSerialNumberText() => serialNumberLabel.Text;
        public string GetFirmwareVersionText() => firmwareVersionLabel.Text;
    }
}