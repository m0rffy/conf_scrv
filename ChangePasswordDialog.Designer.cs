namespace Uetm_2_0
{
    partial class ChangePasswordDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbRole = new ComboBox();
            txtCurrent = new TextBox();
            txtNew = new TextBox();
            txtConfirm = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            labelRole = new Label();
            labelCurrent = new Label();
            labelNew = new Label();
            labelConfirm = new Label();
            SuspendLayout();
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.None;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Times New Roman", 12F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Администратор", "Пользователь" });
            cmbRole.Location = new Point(271, 12);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(135, 27);
            cmbRole.TabIndex = 0;
            // 
            // txtCurrent
            // 
            txtCurrent.Anchor = AnchorStyles.None;
            txtCurrent.Font = new Font("Times New Roman", 12F);
            txtCurrent.Location = new Point(271, 45);
            txtCurrent.MaxLength = 15;
            txtCurrent.Name = "txtCurrent";
            txtCurrent.PasswordChar = '*';
            txtCurrent.Size = new Size(135, 26);
            txtCurrent.TabIndex = 1;
            // 
            // txtNew
            // 
            txtNew.Anchor = AnchorStyles.None;
            txtNew.Font = new Font("Times New Roman", 12F);
            txtNew.Location = new Point(271, 82);
            txtNew.MaxLength = 15;
            txtNew.Name = "txtNew";
            txtNew.PasswordChar = '*';
            txtNew.Size = new Size(135, 26);
            txtNew.TabIndex = 2;
            // 
            // txtConfirm
            // 
            txtConfirm.Anchor = AnchorStyles.None;
            txtConfirm.Font = new Font("Times New Roman", 12F);
            txtConfirm.Location = new Point(271, 116);
            txtConfirm.MaxLength = 15;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(135, 26);
            txtConfirm.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.None;
            btnOk.AutoSize = true;
            btnOk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOk.BackColor = Color.SkyBlue;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Times New Roman", 12F);
            btnOk.Location = new Point(104, 155);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(98, 31);
            btnOk.TabIndex = 4;
            btnOk.Text = "Применить";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.AutoSize = true;
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.BackColor = Color.SkyBlue;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Times New Roman", 12F);
            btnCancel.Location = new Point(224, 155);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(73, 31);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // labelRole
            // 
            labelRole.Anchor = AnchorStyles.None;
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Times New Roman", 12F);
            labelRole.Location = new Point(12, 14);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(156, 19);
            labelRole.TabIndex = 1;
            labelRole.Text = "Изменить пароль для:";
            // 
            // labelCurrent
            // 
            labelCurrent.Anchor = AnchorStyles.None;
            labelCurrent.AutoSize = true;
            labelCurrent.Font = new Font("Times New Roman", 12F);
            labelCurrent.Location = new Point(12, 47);
            labelCurrent.Name = "labelCurrent";
            labelCurrent.Size = new Size(236, 19);
            labelCurrent.TabIndex = 2;
            labelCurrent.Text = "Текущий пароль администратора:";
            // 
            // labelNew
            // 
            labelNew.Anchor = AnchorStyles.None;
            labelNew.AutoSize = true;
            labelNew.Font = new Font("Times New Roman", 12F);
            labelNew.Location = new Point(12, 84);
            labelNew.Name = "labelNew";
            labelNew.Size = new Size(255, 19);
            labelNew.TabIndex = 3;
            labelNew.Text = "Новый пароль для выбранной роли:";
            // 
            // labelConfirm
            // 
            labelConfirm.Anchor = AnchorStyles.None;
            labelConfirm.AutoSize = true;
            labelConfirm.Font = new Font("Times New Roman", 12F);
            labelConfirm.Location = new Point(12, 118);
            labelConfirm.Name = "labelConfirm";
            labelConfirm.Size = new Size(222, 19);
            labelConfirm.TabIndex = 4;
            labelConfirm.Text = "Подтверждение нового пароля:";
            // 
            // ChangePasswordDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 207);
            Controls.Add(cmbRole);
            Controls.Add(labelRole);
            Controls.Add(txtCurrent);
            Controls.Add(labelCurrent);
            Controls.Add(txtNew);
            Controls.Add(labelNew);
            Controls.Add(txtConfirm);
            Controls.Add(labelConfirm);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.Label labelConfirm;
    }
}