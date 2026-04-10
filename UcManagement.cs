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

        // Переменная для хранения последнего введённого IP (только во время работы программы)
        private string _lastIp = "-";

        public UcManagement(ConfiguratorForm mainForm)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.mainForm = mainForm;
            InitializeDataTables();
            InitializeBackgroundWorker();

            mainForm.ConnectionStarted += OnConnectionStarted;
            mainForm.ConnectionStopped += OnConnectionStopped;

            // Загружаем последний IP из переменной (при запуске значение по умолчанию)
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
            rmsTable.Columns.Add("Значение, А", typeof(float));
            rmsDataGridView.DataSource = rmsTable;
            rmsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rmsDataGridView.RowHeadersVisible = false;
            rmsDataGridView.ReadOnly = true;
            rmsDataGridView.Columns[1].DefaultCellStyle.Format = "0.00";
            rmsDataGridView.DataError += (s, e) => e.ThrowException = false;

            cntvTable = new DataTable();
            cntvTable.Columns.Add("Канал", typeof(string));
            cntvTable.Columns.Add("Выработанный ресурс, %", typeof(float));
            cntvTable.Columns.Add("Кол-во отключений", typeof(ushort));
            cntvTable.Columns.Add("Кол-во включений", typeof(ushort));
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
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
            SafeInvoke(() =>
            {
                rmsTable.Rows.Clear();
                cntvTable.Rows.Clear();
                deviceStatusLabel.Text = "-";
                syncStatusLabel.Text = "-";
                rtcStatusLabel.Text = "-";
                deviceTimeLabel.Text = "-";
                serialNumberLabel.Text = "-";
                firmwareVersionLabel.Text = "-";
            });
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var connection = e.Argument as Tuple<TcpClient, IModbusMaster>;
            if (connection == null) return;
            TcpClient tcpClient = connection.Item1;
            IModbusMaster modbusMaster = connection.Item2;

            while (!backgroundWorker.CancellationPending)
            {
                if (!tcpClient.Connected) break;
                try
                {
                    var esp = profileHelper.ect_state_page_Read(modbusMaster);
                    var ssp = profileHelper.swrct_state_page_Read(modbusMaster);
                    var timeData = profileHelper.time_Read(modbusMaster);
                    DateTime dt = PtpTimeHelper.PtpToDateTime(timeData.ptpval.ns, timeData.ptpval.slo, timeData.ptsecHi);
                    var cmns = profileHelper.cmns_Read(modbusMaster);

                    SafeInvoke(() =>
                    {
                        UpdateRmsTable(esp.rms);
                        UpdateCntvTable(ssp.cntv);
                        UpdateStatus(esp.ste);
                        UpdateRtcStatus(ssp.ste[2]);
                        deviceTimeLabel.Text = dt.ToString("dd.MM.yyyy HH:mm:ss");
                        serialNumberLabel.Text = cmns.SerialNo.ToString();
                        firmwareVersionLabel.Text = cmns.FmwVer.ToString();
                    });
                    System.Threading.Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    // Игнорируем ошибки разрыва соединения
                    if (msg.Contains("transport connection") ||
                        msg.Contains("disconnected") ||
                        msg.Contains("non-connected sockets") ||
                        msg.Contains("not allowed on non-connected sockets") ||
                        (ex.InnerException?.Message?.Contains("transport connection") == true))
                    {
                        break; // просто выходим из цикла
                    }
                    SafeInvoke(() => MessageBox.Show($"Ошибка чтения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    break;
                }
            }
        }

        private void UpdateRmsTable(float[] rms)
        {
            rmsTable.Rows.Clear();
            float inom1 = 1.0f;
            string inom1Str = Database.GeneralSettings_TextFormat.meas.primct.Inom1;
            if (!string.IsNullOrEmpty(inom1Str))
                float.TryParse(inom1Str, NumberStyles.Any, CultureInfo.InvariantCulture, out inom1);

            for (int i = 0; i < Math.Min(3, rms.Length); i++)
            {
                string channel = i == 0 ? "A" : i == 1 ? "B" : "C";
                float current = (float)Math.Sqrt(Math.Max(0, rms[i])) * inom1;
                rmsTable.Rows.Add(channel, current);
            }
        }

        private void UpdateCntvTable(ModBusProfile.SWCNT[] cntv)
        {
            cntvTable.Rows.Clear();
            for (int i = 0; i < Math.Min(3, cntv.Length); i++)
            {
                string channel = i == 0 ? "A" : i == 1 ? "B" : "C";
                cntvTable.Rows.Add(channel, cntv[i].Racc, cntv[i].ofcnt, cntv[i].oNacnt);
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
                MessageBox.Show("Некорректный порт.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Database.Devices.Exists(d => d.IP == ip))
            {
                MessageBox.Show("Устройство с таким IP уже есть в списке.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Сохраняем последний IP в переменную (не очищаем поле)
            _lastIp = ip;

            var newDev = new DeviceInfo
            {
                IP = ip,
                Port = port,
                InstallationPlace = "-",
                SwitchLabel = "-"
            };
            Database.Devices.Add(newDev);
            Database.SaveDevices();
            mainForm.RefreshDevicesList();
            // Не очищаем ipTextBox – оставляем введённое значение
            portTextBox.Text = "-";
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

            if (MessageBox.Show("Установить новое время? Устройство перезагрузится.", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            var conn = mainForm.GetCurrentConnection();
            if (conn?.Item1?.Connected != true)
            {
                MessageBox.Show("Нет подключения к устройству.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка PTP-синхронизации
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
                        registers[5] = 0; // opts

                        conn.Item2.WriteMultipleRegisters(0, 2816, registers);

                        var commands = new ModBusCommands();
                        var response = commands.upload_settings(conn.Item2, 0x0100);
                        if (response?.Data != null && response.Data[0] == 0xFF)
                        {
                            MessageBox.Show("Время установлено. Устройство перезагружается.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mainForm.Disconnect();
                            mainForm.RefreshDevicesList();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка сохранения времени. Возможно, устройство не поддерживает запись времени во flash.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Игнорируем ошибки разрыва соединения при перезагрузке
                        if (!ex.Message.Contains("transport connection") &&
                            !ex.Message.Contains("disconnected") &&
                            (ex.InnerException?.Message?.Contains("transport connection") != true))
                        {
                            MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        // В любом случае отключаемся
                        mainForm.Disconnect();
                        mainForm.RefreshDevicesList();
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
                    // Игнорируем ошибки разрыва соединения
                    if (!ex.Message.Contains("transport connection") &&
                        !ex.Message.Contains("disconnected") &&
                        (ex.InnerException?.Message?.Contains("transport connection") != true))
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // В любом случае отключаемся
                    mainForm.Disconnect();
                    mainForm.RefreshDevicesList();
                }
            }
            else
            {
                MessageBox.Show("Нет подключения к устройству.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Публичные методы для экспорта
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