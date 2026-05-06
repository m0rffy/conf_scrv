using ModBusHelper;
using NModbus;
using NModbus.Message;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Net;
using System.Net.Sockets;

namespace Uetm_2_0
{
    public partial class UcManagement : UserControl
    {
        private readonly ConfiguratorForm mainForm;
        private BackgroundWorker backgroundWorker;
        private DataTable rmsTable;
        private DataTable cntvTable;
        private readonly ModBusProfile profileHelper = new();
        private readonly ModBusCommands commandsHelper = new();
        private Tuple<TcpClient, IModbusMaster> _connection;
        private string _lastIp = "";
        private bool _manualTimeSet = false;
        private float _inom1 = 1.0f; // для пересчёта тока

        public UcManagement(ConfiguratorForm mainForm)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.mainForm = mainForm;
            InitializeDataTables();
            InitializeBackgroundWorker();

            mainForm.ConnectionStarted += OnConnectionStarted;
            mainForm.ConnectionStopped += OnConnectionStopped;

            ipTextBox.Text = _lastIp;

            Tuple<TcpClient, IModbusMaster> existingConnection = mainForm.GetCurrentConnection();
            if (existingConnection != null && existingConnection.Item1.Connected)
            {
                OnConnectionStarted(existingConnection);
            }
        }

        private void InitializeDataTables()
        {
            rmsTable = new DataTable();
            _ = rmsTable.Columns.Add("Канал", typeof(string));
            _ = rmsTable.Columns.Add("Значение (А)", typeof(float));
            rmsDataGridView.DataSource = rmsTable;
            rmsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rmsDataGridView.RowHeadersVisible = false;
            rmsDataGridView.ReadOnly = true;
            rmsDataGridView.Columns[1].DefaultCellStyle.Format = "0.00";
            rmsDataGridView.DataError += (s, e) => e.ThrowException = false;

            cntvTable = new DataTable();
            _ = cntvTable.Columns.Add("Канал", typeof(string));
            _ = cntvTable.Columns.Add("Выработанный ресурс (%)", typeof(float));
            _ = cntvTable.Columns.Add("Количество отключений", typeof(int));
            _ = cntvTable.Columns.Add("Количество включений", typeof(int));
            cntvDataGridView.DataSource = cntvTable;
            cntvDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cntvDataGridView.RowHeadersVisible = false;
            cntvDataGridView.ReadOnly = true;
            cntvDataGridView.Columns[1].DefaultCellStyle.Format = "0.00";
            cntvDataGridView.DataError += (s, e) => e.ThrowException = false;
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
        }

        private void OnConnectionStarted(Tuple<TcpClient, IModbusMaster> connection)
        {
            _connection = connection;

            // Гарантируем, что старый воркер полностью остановлен перед запуском нового
            WaitForBackgroundWorkerStop();

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
            if (ex == null)
            {
                return false;
            }

            if (ex is AggregateException agg)
            {
                return agg.InnerExceptions.Any(IsConnectionError);
            }

            if (ex is SocketException or IOException)
            {
                return true;
            }

            if (ex is InvalidOperationException && ex.Message.Contains("connected"))
            {
                return true;
            }

            string msg = ex.Message.ToLower();
            return msg.Contains("socket") ||
                   msg.Contains("connection") ||
                   msg.Contains("disconnected") ||
                   msg.Contains("transport") ||
                   msg.Contains("disposed") ||
                   msg.Contains("timeout") ||
                   msg.Contains("broken pipe") ||
                   (ex.InnerException != null && IsConnectionError(ex.InnerException));
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is not Tuple<TcpClient, IModbusMaster> connection)
            {
                return;
            }

            TcpClient tcpClient = connection.Item1;
            IModbusMaster modbusMaster = connection.Item2;
            string? deviceIP = null;
            if (tcpClient?.Client?.RemoteEndPoint is IPEndPoint ep)
            {
                deviceIP = ep.Address.ToString();
                if (deviceIP.StartsWith("::ffff:"))
                {
                    deviceIP = deviceIP[7..];
                }
            }

            while (!backgroundWorker.CancellationPending)
            {
                if (tcpClient == null || !tcpClient.Connected)
                {
                    SafeInvoke(mainForm.Disconnect);
                    break;
                }

                try
                {
                    ModBusProfile.esp esp = profileHelper.ect_state_page_Read(modbusMaster);
                    ModBusProfile.ssp ssp = profileHelper.swrct_state_page_Read(modbusMaster);
                    ModBusProfile.time timeData = profileHelper.time_Read(modbusMaster);
                    DateTime dt = PtpTimeHelper.PtpToDateTime(timeData.ptpval.ns, timeData.ptpval.slo, timeData.ptsecHi);
                    ModBusProfile.cmns cmns = profileHelper.cmns_Read(modbusMaster);

                    // Вычисляем Inom1 для пересчёта тока
                    float inom1 = 1.0f;
                    string inom1Str = Database.GeneralSettings_TextFormat.meas.primct.Inom1;
                    if (!string.IsNullOrEmpty(inom1Str))
                    {
                        _ = float.TryParse(inom1Str, NumberStyles.Any, CultureInfo.InvariantCulture, out inom1);
                    }

                    _inom1 = inom1;

                    SafeInvoke(() =>
                    {
                        UpdateRmsTable(esp.rms);
                        UpdateCntvTable(ssp.cntv);
                        UpdateStatus(esp.ste);
                        UpdateRtcStatus(ssp.ste[2]);
                        if (!_manualTimeSet)
                        {
                            deviceTimeLabel.Text = dt.ToString("dd.MM.yyyy HH:mm:ss");
                        }

                        serialNumberLabel.Text = cmns.SerialNo.ToString();
                        firmwareVersionLabel.Text = cmns.FmwVer.ToString();
                    });
                }
                catch (Exception ex)
                {
                    if (IsConnectionError(ex))
                    {
                        SafeInvoke(mainForm.Disconnect);
                        break;
                    }
                    else
                    {
                        SafeInvoke(() => MessageBox.Show($"Ошибка чтения: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error));
                        break;
                    }
                }

                // Интервал между опросами
                System.Threading.Thread.Sleep(2000);
            }
        }

        private void UpdateRmsTable(float[] rms)
        {
            rmsTable.Rows.Clear();
            // Реальный порядок в устройстве: 0=A, 1=B, 2=C, 3=N
            // Отображаем только A(0), B(1), C(2)
            string[] labels = { "A", "B", "C" };
            for (int i = 0; i < labels.Length; i++)
            {
                if (i < rms.Length)
                {
                    float current = (float)Math.Sqrt(Math.Max(0, rms[i])) * _inom1;
                    _ = rmsTable.Rows.Add(labels[i], current);
                }
            }
        }

        private void UpdateCntvTable(ModBusProfile.SWCNT[] cntv)
        {
            cntvTable.Rows.Clear();
            string[] labels = { "A", "B", "C" };
            for (int i = 0; i < labels.Length; i++)
            {
                if (i < cntv.Length)
                {
                    _ = cntvTable.Rows.Add(labels[i], cntv[i].Racc, cntv[i].ofcnt, cntv[i].oNacnt);
                }
            }
        }

        private void UpdateStatus(byte[] ste)
        {
            deviceStatusLabel.Text = (ste.Length > 0 && ste[0] == 0) ? "В работе" : "Ошибка";
            if (ste.Length > 1)
            {
                syncStatusLabel.Text = ste[1] switch
                {
                    0 => "Не синхронизированы",
                    1 => "Грубая",
                    2 => "Точная",
                    _ => "Неизвестно"
                };
            }
        }

        private void UpdateRtcStatus(byte rtcSte)
        {
            rtcStatusLabel.Text = rtcSte == 0 ? "Работают" : "Ошибка";
        }

        private void SafeInvoke(Action action)
        {
            if (IsDisposed || Disposing)
            {
                return;
            }

            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        // ======================= Кнопки управления =======================

        private void AddDeviceButton_Click(object sender, EventArgs e)
        {
            string ip = ipTextBox.Text.Trim();
            if (!IPAddress.TryParse(ip, out _))
            {
                _ = MessageBox.Show("Некорректный IP адрес.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(portTextBox.Text, out int port) || port < 1 || port > 65535)
            {
                _ = MessageBox.Show("Некорректный порт (1–65535).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Database.Devices.Exists(d => d.IP == ip))
            {
                _ = MessageBox.Show("Устройство с таким IP уже есть в списке.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _lastIp = ip;

            DeviceInfo newDev = new()
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
                _ = MessageBox.Show("Требуются права администратора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Обнулить счётчик ресурса выключателя?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            Tuple<TcpClient, IModbusMaster> conn = mainForm.GetCurrentConnection();
            if (conn?.Item1?.Connected == true)
            {
                try
                {
                    WriteSingleRegisterRequestResponse response = commandsHelper.nulify_swrc(conn.Item2);
                    _ = response.Data[0] == 0xFF
                        ? MessageBox.Show("Счётчик ресурса обнулён.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        : MessageBox.Show("Ошибка обнуления счётчика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _ = MessageBox.Show("Нет подключения к устройству.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetTimeButton_Click(object sender, EventArgs e)
        {
            if (Database.CurrentRole != "Администратор")
            {
                _ = MessageBox.Show("Требуются права администратора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tuple<TcpClient, IModbusMaster> conn = mainForm.GetCurrentConnection();
            if (conn?.Item1?.Connected != true)
            {
                _ = MessageBox.Show("Нет подключения к устройству.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ModBusProfile.esp esp = profileHelper.ect_state_page_Read(conn.Item2);
                if (esp.ste.Length > 1 && esp.ste[1] != 0)
                {
                    _ = MessageBox.Show("Невозможно изменить время – устройство синхронизировано с PTP мастером.",
                        "Операция запрещена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Ошибка проверки синхронизации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using SetTimeDialog dialog = new();
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

                    ModBusCommands commands = new();
                    _ = commands.upload_settings(conn.Item2, 0x0100);

                    SafeInvoke(() => deviceTimeLabel.Text = dialog.SelectedDateTime.ToString("dd.MM.yyyy HH:mm:ss"));
                    mainForm.Disconnect();
                    mainForm.RefreshDevicesList();

                    _ = MessageBox.Show("Время установлено. Устройство перезагружается. Подождите несколько секунд и подключитесь заново.",
                        "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (IsConnectionError(ex))
                    {
                        SafeInvoke(() => deviceTimeLabel.Text = dialog.SelectedDateTime.ToString("dd.MM.yyyy HH:mm:ss"));
                        mainForm.Disconnect();
                        mainForm.RefreshDevicesList();
                        _ = MessageBox.Show("Время установлено. Устройство перезагружается.",
                            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _ = MessageBox.Show($"Ошибка установки времени: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void WaitForBackgroundWorkerStop()
        {
            if (backgroundWorker == null)
            {
                return;
            }

            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
                // Ожидаем завершение с обработкой сообщений UI, чтобы не подвесить форму
                while (backgroundWorker.IsBusy)
                {
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(20);
                }
            }
        }

        private void RebootButton_Click(object sender, EventArgs e)
        {
            if (Database.CurrentRole != "Администратор")
            {
                _ = MessageBox.Show("Требуются права администратора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Перезагрузить устройство? Соединение будет разорвано.", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            Tuple<TcpClient, IModbusMaster> conn = mainForm.GetCurrentConnection();
            if (conn?.Item1?.Connected == true)
            {
                try
                {
                    WriteSingleRegisterRequestResponse response = commandsHelper.reset_ect(conn.Item2);
                    if (response.Data[0] == 0xFF)
                    {
                        _ = MessageBox.Show("Устройство перезагружается.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainForm.Disconnect();
                        mainForm.RefreshDevicesList();
                    }
                    else
                    {
                        _ = MessageBox.Show("Ошибка перезагрузки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    if (IsConnectionError(ex))
                    {
                        _ = MessageBox.Show("Устройство перезагружается.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainForm.Disconnect();
                        mainForm.RefreshDevicesList();
                    }
                    else
                    {
                        _ = MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                _ = MessageBox.Show("Нет подключения к устройству.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Публичные свойства для экспорта в Excel
        public DataTable GetRmsDataTable()
        {
            return rmsTable;
        }

        public DataTable GetCntvDataTable()
        {
            return cntvTable;
        }

        public string GetDeviceStatusText()
        {
            return deviceStatusLabel.Text;
        }

        public string GetSyncStatusText()
        {
            return syncStatusLabel.Text;
        }

        public string GetRtcStatusText()
        {
            return rtcStatusLabel.Text;
        }

        public string GetDeviceTimeText()
        {
            return deviceTimeLabel.Text;
        }

        public string GetSerialNumberText()
        {
            return serialNumberLabel.Text;
        }

        public string GetFirmwareVersionText()
        {
            return firmwareVersionLabel.Text;
        }
    }
}