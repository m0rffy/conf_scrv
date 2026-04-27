using System.Drawing.Drawing2D;

namespace Uetm_2_0
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            LoginComboBox.Items.Add("Администратор");
            LoginComboBox.Items.Add("Пользователь");
            LoginComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(LoginComboBox.Text))
            {
                MessageBox.Show("Выберите уровень доступа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Введите пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string role = LoginComboBox.Text;
            string password = PasswordTextBox.Text;

            // Получаем пароль из базы (или из памяти, если загружен)
            if (!Database.AppData.Passwords.TryGetValue(role, out string storedPassword) ||
                storedPassword != password)
            {
                MessageBox.Show("Неверный пароль.");
                return;
            }

            Database.CurrentRole = role;

            ConfiguratorForm form = new(role);
            form.FormClosed += (s, args) => { this.Show(); };
            form.Show();
            this.Hide();
        }
    }
}