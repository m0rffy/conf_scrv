using ModBusHelper;
using OfficeOpenXml;
using System.Data;

namespace Uetm_2_0
{
    public partial class UcJournal : UserControl
    {
        private ConfiguratorForm mainForm;
        private ModBusProfile profileHelper = new ModBusProfile();
        private DataTable journalTable;
        private List<ModBusProfile.journal_record> records;

        public UcJournal(ConfiguratorForm mainForm)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.mainForm = mainForm;

            // Таблица журнала (столбцы едины для локальных событий и событий платы)
            journalTable = new DataTable();
            journalTable.Columns.Add("№", typeof(int));
            journalTable.Columns.Add("Тип события", typeof(string));
            journalTable.Columns.Add("Канал / IP", typeof(string));   // буква фазы или IP устройства
            journalTable.Columns.Add("Дата и время", typeof(string));
            journalTable.Columns.Add("Ток (А)", typeof(float));
            journalTable.Columns.Add("Ресурс (%)", typeof(float));

            journalDataGridView.DataSource = journalTable;
            journalDataGridView.AutoGenerateColumns = true;
        }

        private string ChannelNumberToLetter(int number)
        {
            return number switch
            {
                1 => "A",
                2 => "B",
                3 => "C",
                _ => "-"
            };
        }

        // ==================== Кнопка "Обновить" ====================
        private void UpdateJournalButton_Click(object sender, EventArgs e)
        {
            journalTable.Rows.Clear();
            int idx = 0;

            // ----- 1. Локальные события (из таблицы ChangeLog) -----
            try
            {
                var localEntries = LocalDatabase.GetLogEntries(1000);   // последние 1000 записей
                foreach (var entry in localEntries)
                {
                    journalTable.Rows.Add(
                        idx,
                        entry.Description,                              // Тип события (например, «Настройки записаны...»)
                        entry.DeviceIP ?? "",                           // IP устройства (для локальных событий)
                        entry.Timestamp.ToString("dd.MM.yyyy HH:mm:ss"),
                        entry.CurrentA ?? (object)DBNull.Value,         // Ток (если был зафиксирован)
                        entry.ResourcePercent ?? (object)DBNull.Value   // Ресурс (если был зафиксирован)
                    );
                    idx++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения локального журнала: {ex.Message}");
            }

            // ----- 2. Журнал с устройства (только при активном подключении) -----
            var conn = mainForm.GetCurrentConnection();
            if (conn?.Item1?.Connected == true)
            {
                try
                {
                    records = profileHelper.journal_record_Read(conn.Item2);
                    foreach (var rec in records)
                    {
                        // Отображаем только значащие типы событий
                        if (rec.hdr.rtype == 1 || rec.hdr.rtype == 2)
                        {
                            string eventType = rec.hdr.rtype == 1
                                ? (rec.hdr.subtype == 0 ? "Отключение" : "Включение")
                                : "Обнуление";

                            DateTime dt = PtpTimeHelper.PtpToDateTime(rec.hdr.stamp.ns, rec.hdr.stamp.slo);
                            string channel = (rec.hdr.rtype == 1) ? ChannelNumberToLetter(rec.hdr.udt) : "";

                            journalTable.Rows.Add(
                                idx,
                                eventType,
                                channel,                                    // буква фазы для событий платы
                                dt.ToString("dd.MM.yyyy HH:mm:ss"),
                                rec.Ii,
                                rec.Ri
                            );
                            idx++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка чтения журнала устройства: {ex.Message}");
                }
            }

            MessageBox.Show($"Загружено {journalTable.Rows.Count} записей");
        }

        // ==================== Кнопка "Экспорт в Excel" ====================
        private void ExportButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel файлы (*.xlsx)|*.xlsx";
                sfd.DefaultExt = "xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Лицензия EPPlus (некоммерческое использование)
                        ExcelPackage.License.SetNonCommercialPersonal("Пользователь UETM");

                        using (var package = new ExcelPackage())
                        {
                            // Лист "Состояние"
                            var wsState = package.Workbook.Worksheets.Add("Состояние");
                            FillStateSheet(wsState);

                            // Лист "Общие настройки"
                            var wsGeneral = package.Workbook.Worksheets.Add("Общие настройки");
                            FillGeneralSheet(wsGeneral);

                            // Лист "Сетевые настройки"
                            var wsNetwork = package.Workbook.Worksheets.Add("Сетевые настройки");
                            FillNetworkSheet(wsNetwork);

                            // Лист "Журнал"
                            var wsJournal = package.Workbook.Worksheets.Add("Журнал");
                            FillJournalSheet(wsJournal);

                            FileInfo fi = new FileInfo(sfd.FileName);
                            package.SaveAs(fi);
                        }
                        MessageBox.Show("Экспорт завершён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка экспорта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ==================== Вспомогательные методы экспорта ====================
        private void FillStateSheet(ExcelWorksheet ws)
        {
            ws.Cells[1, 1].Value = "Параметр";
            ws.Cells[1, 2].Value = "Значение";
            int row = 2;

            ws.Cells[row, 1].Value = "Статус устройства";
            ws.Cells[row, 2].Value = mainForm.ucManagement.GetDeviceStatusText();
            row++;
            ws.Cells[row, 1].Value = "Синхронизация PTP";
            ws.Cells[row, 2].Value = mainForm.ucManagement.GetSyncStatusText();
            row++;
            ws.Cells[row, 1].Value = "Состояние RTC";
            ws.Cells[row, 2].Value = mainForm.ucManagement.GetRtcStatusText();
            row++;
            ws.Cells[row, 1].Value = "Время устройства";
            ws.Cells[row, 2].Value = mainForm.ucManagement.GetDeviceTimeText();
            row++;
            ws.Cells[row, 1].Value = "Серийный номер";
            ws.Cells[row, 2].Value = mainForm.ucManagement.GetSerialNumberText();
            row++;
            ws.Cells[row, 1].Value = "Версия прошивки";
            ws.Cells[row, 2].Value = mainForm.ucManagement.GetFirmwareVersionText();
            row += 2;

            // Действующие значения тока
            ws.Cells[row, 1].Value = "Действующие значения тока";
            row++;
            ws.Cells[row, 1].Value = "Канал";
            ws.Cells[row, 2].Value = "Значение (А)";
            DataTable rms = mainForm.ucManagement.GetRmsDataTable();
            int rmsRow = row + 1;
            foreach (DataRow dr in rms.Rows)
            {
                ws.Cells[rmsRow, 1].Value = dr[0].ToString();
                ws.Cells[rmsRow, 2].Value = Convert.ToDouble(dr[1]);
                rmsRow++;
            }

            row = rmsRow + 2;
            ws.Cells[row, 1].Value = "Ресурс выключателя";
            row++;
            ws.Cells[row, 1].Value = "Канал";
            ws.Cells[row, 2].Value = "Ресурс (%)";
            ws.Cells[row, 3].Value = "Отключений";
            ws.Cells[row, 4].Value = "Включений";
            DataTable cntv = mainForm.ucManagement.GetCntvDataTable();
            int cntvRow = row + 1;
            foreach (DataRow dr in cntv.Rows)
            {
                ws.Cells[cntvRow, 1].Value = dr[0].ToString();
                ws.Cells[cntvRow, 2].Value = Convert.ToDouble(dr[1]);
                ws.Cells[cntvRow, 3].Value = Convert.ToInt32(dr[2]);
                ws.Cells[cntvRow, 4].Value = Convert.ToInt32(dr[3]);
                cntvRow++;
            }
            ws.Cells.AutoFitColumns();
        }

        private void FillGeneralSheet(ExcelWorksheet ws)
        {
            var dict = mainForm.ucGeneral.GetGeneralSettingsDictionary();
            int row = 1;
            foreach (var kvp in dict)
            {
                ws.Cells[row, 1].Value = kvp.Key;
                ws.Cells[row, 2].Value = kvp.Value;
                row++;
            }

            row++;
            ws.Cells[row, 1].Value = "Задержки срабатывания (мс)";
            row++;
            ws.Cells[row, 1].Value = "Канал";
            ws.Cells[row, 2].Value = "Отключение";
            ws.Cells[row, 3].Value = "Включение";
            DataTable delay = mainForm.ucGeneral.GetDelayTable();
            int delayRow = row + 1;
            foreach (DataRow dr in delay.Rows)
            {
                ws.Cells[delayRow, 1].Value = dr[0].ToString();
                ws.Cells[delayRow, 2].Value = dr[1].ToString();
                ws.Cells[delayRow, 3].Value = dr[2].ToString();
                delayRow++;
            }
            ws.Cells.AutoFitColumns();
        }

        private void FillNetworkSheet(ExcelWorksheet ws)
        {
            var dict = mainForm.ucNetwork.GetNetworkSettingsDictionary();
            int row = 1;
            foreach (var kvp in dict)
            {
                ws.Cells[row, 1].Value = kvp.Key;
                ws.Cells[row, 2].Value = kvp.Value;
                row++;
            }
            ws.Cells.AutoFitColumns();
        }

        private void FillJournalSheet(ExcelWorksheet ws)
        {
            if (journalTable.Rows.Count == 0)
            {
                ws.Cells[1, 1].Value = "Нет записей в журнале";
                return;
            }
            // Заголовки столбцов
            for (int i = 0; i < journalTable.Columns.Count; i++)
                ws.Cells[1, i + 1].Value = journalTable.Columns[i].ColumnName;

            // Данные
            for (int i = 0; i < journalTable.Rows.Count; i++)
                for (int j = 0; j < journalTable.Columns.Count; j++)
                    ws.Cells[i + 2, j + 1].Value = journalTable.Rows[i][j]?.ToString();
            ws.Cells.AutoFitColumns();
        }
    }
}