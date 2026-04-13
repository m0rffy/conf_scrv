namespace Uetm_2_0
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();

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

            if (role == "Администратор" && password != "admin")
            {
                MessageBox.Show("Неверный пароль для администратора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (role == "Пользователь" && password != "user")
            {
                MessageBox.Show("Неверный пароль для пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Database.CurrentRole = role;

            ConfiguratorForm form = new(role);
            form.FormClosed += (s, args) =>
            {
                // После закрытия ConfiguratorForm показываем окно авторизации снова
                this.Show();
            };
            form.Show();
            this.Hide();
        }

       
    }
}