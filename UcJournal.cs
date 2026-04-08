using ModBusHelper;
using System.Data;
using System.Globalization;

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

          

            journalTable = new DataTable();
            journalTable.Columns.Add("№", typeof(int));
            journalTable.Columns.Add("Тип события", typeof(string));
            journalTable.Columns.Add("Канал", typeof(string));   // строка
            journalTable.Columns.Add("Дата и время", typeof(string));
            journalTable.Columns.Add("Действующее значение тока (А)", typeof(float));
            journalTable.Columns.Add("Выработанный ресурс (%)", typeof(float));

            journalDataGridView.DataSource = journalTable;
            journalDataGridView.AutoGenerateColumns = true;
            journalDataGridView.DataError += (s, e) => e.ThrowException = false;
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

        private void UpdateJournalButton_Click(object sender, EventArgs e)
        {
            var conn = mainForm.GetCurrentConnection();
            if (conn?.Item1?.Connected != true)
            {
                MessageBox.Show("Нет подключения к устройству.");
                return;
            }
            try
            {
                records = profileHelper.journal_record_Read(conn.Item2);
                journalTable.Rows.Clear();
                int idx = 0;
                foreach (var rec in records)
                {
                    if (rec.hdr.rtype == 1 || rec.hdr.rtype == 2)
                    {
                        string eventType = rec.hdr.rtype == 1 ? (rec.hdr.subtype == 0 ? "Отключение" : "Включение") : "Обнуление";
                        DateTime dt = PtpTimeHelper.PtpToDateTime(rec.hdr.stamp.ns, rec.hdr.stamp.slo);
                        string channel = (rec.hdr.rtype == 1) ? ChannelNumberToLetter(rec.hdr.udt) : "-";
                        journalTable.Rows.Add(idx, eventType, channel, dt.ToString("dd.MM.yyyy HH:mm:ss"), rec.Ii, rec.Ri);
                        idx++;
                    }
                }
                MessageBox.Show($"Загружено {journalTable.Rows.Count} записей.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения журнала: {ex.Message}");
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (journalTable.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта.");
                return;
            }
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV файлы (*.csv)|*.csv";
                sfd.DefaultExt = "csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(string.Join(";", "№", "Тип события", "Канал", "Дата и время", "Ток (А)", "Ресурс (%)"));
                            foreach (DataRow row in journalTable.Rows)
                            {
                                sw.WriteLine(string.Join(";", row[0], row[1], row[2], row[3], row[4], row[5]));
                            }
                        }
                        MessageBox.Show("Экспорт выполнен.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка экспорта: {ex.Message}");
                    }
                }
            }
        }

    }
}