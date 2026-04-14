namespace Uetm_2_0
{
    partial class Auth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            LoginLabel = new Label();
            LoginComboBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.None;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordLabel.Location = new Point(83, 84);
            PasswordLabel.Margin = new Padding(8, 0, 8, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(69, 21);
            PasswordLabel.TabIndex = 84;
            PasswordLabel.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.None;
            PasswordTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(17, 109);
            PasswordTextBox.Margin = new Padding(8, 6, 8, 6);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(201, 29);
            PasswordTextBox.TabIndex = 83;
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.None;
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginLabel.Location = new Point(46, 24);
            LoginLabel.Margin = new Padding(8, 0, 8, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(146, 21);
            LoginLabel.TabIndex = 82;
            LoginLabel.Text = "Уровень доступа";
            LoginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginComboBox
            // 
            LoginComboBox.Anchor = AnchorStyles.None;
            LoginComboBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginComboBox.FormattingEnabled = true;
            LoginComboBox.Items.AddRange(new object[] { "Администратор", "Пользователь" });
            LoginComboBox.Location = new Point(17, 51);
            LoginComboBox.Margin = new Padding(8, 6, 8, 6);
            LoginComboBox.Name = "LoginComboBox";
            LoginComboBox.Size = new Size(201, 29);
            LoginComboBox.TabIndex = 81;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.LightSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(83, 148);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(64, 31);
            button1.TabIndex = 86;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Auth
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightGray;
            ClientSize = new Size(234, 211);
            Controls.Add(button1);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginLabel);
            Controls.Add(LoginComboBox);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(250, 250);
            MinimumSize = new Size(250, 250);
            Name = "Auth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label LoginLabel;
        private ComboBox LoginComboBox;
        private Button button1;
    }
}