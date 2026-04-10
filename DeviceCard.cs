namespace Uetm_2_0
{
    public partial class DeviceCard : UserControl
    {
        private TextBox placeTextBox;
        private TextBox switchTextBox;
        private Button deleteButton;
        private Button connectButton;

        public DeviceCard()
        {
            InitializeComponent();
        }

        public void SetData(string ip, string place, string switchLabel, bool isActive)
        {
            ipLabel.Text = ip;
            placeTextBox.Text = place;
            switchTextBox.Text = switchLabel;
            this.BackColor = isActive ? Color.PaleGreen : Color.LightGray;
            connectButton.Text = isActive ? "Отключиться" : "Подключиться";
        }

        public event EventHandler DeleteClicked;
        public event EventHandler ConnectClicked;

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, e);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ConnectClicked?.Invoke(this, e);
        }
    }
}
