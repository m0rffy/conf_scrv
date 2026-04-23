namespace Uetm_2_0
{
    public partial class SetTimeDialog : Form
    {
        public DateTime SelectedDateTime { get; private set; }

        public SetTimeDialog()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            numericUpDownHour.Value = DateTime.Now.Hour;
            numericUpDownMinute.Value = DateTime.Now.Minute;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DateTime baseDate = dateTimePicker1.Value.Date;
            SelectedDateTime = baseDate.AddHours((double)numericUpDownHour.Value)
                                       .AddMinutes((double)numericUpDownMinute.Value);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        
    }
}