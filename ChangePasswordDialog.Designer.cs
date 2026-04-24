namespace Uetm_2_0
{
    partial class ChangePasswordDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtCurrent = new TextBox();
            txtNew = new TextBox();
            txtConfirm = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            labelCurrent = new Label();
            labelNew = new Label();
            labelConfirm = new Label();
            SuspendLayout();
            // 
            // txtCurrent
            // 
            txtCurrent.Anchor = AnchorStyles.None;
            txtCurrent.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtCurrent.Location = new Point(137, 23);
            txtCurrent.Margin = new Padding(4, 4, 4, 4);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.Size = new Size(150, 26);
            txtCurrent.TabIndex = 1;
            // 
            // txtNew
            // 
            txtNew.Anchor = AnchorStyles.None;
            txtNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNew.Location = new Point(137, 76);
            txtNew.Margin = new Padding(4, 4, 4, 4);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(150, 26);
            txtNew.TabIndex = 3;
            // 
            // txtConfirm
            // 
            txtConfirm.Anchor = AnchorStyles.None;
            txtConfirm.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtConfirm.Location = new Point(135, 128);
            txtConfirm.Margin = new Padding(4, 4, 4, 4);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(150, 26);
            txtConfirm.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.None;
            btnOk.AutoSize = true;
            btnOk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOk.BackColor = Color.SkyBlue;
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnOk.Location = new Point(135, 174);
            btnOk.Margin = new Padding(4, 4, 4, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(43, 29);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.AutoSize = true;
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.BackColor = Color.SkyBlue;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCancel.Location = new Point(216, 174);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(71, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // labelCurrent
            // 
            labelCurrent.Anchor = AnchorStyles.None;
            labelCurrent.AutoSize = true;
            labelCurrent.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCurrent.Location = new Point(11, 26);
            labelCurrent.Margin = new Padding(4, 0, 4, 0);
            labelCurrent.Name = "labelCurrent";
            labelCurrent.Size = new Size(118, 19);
            labelCurrent.TabIndex = 0;
            labelCurrent.Text = "Текущий пароль";
            // 
            // labelNew
            // 
            labelNew.Anchor = AnchorStyles.None;
            labelNew.AutoSize = true;
            labelNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNew.Location = new Point(22, 79);
            labelNew.Margin = new Padding(4, 0, 4, 0);
            labelNew.Name = "labelNew";
            labelNew.Size = new Size(107, 19);
            labelNew.TabIndex = 2;
            labelNew.Text = "Новый пароль";
            // 
            // labelConfirm
            // 
            labelConfirm.Anchor = AnchorStyles.None;
            labelConfirm.AutoSize = true;
            labelConfirm.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelConfirm.Location = new Point(10, 135);
            labelConfirm.Margin = new Padding(4, 0, 4, 0);
            labelConfirm.Name = "labelConfirm";
            labelConfirm.Size = new Size(117, 19);
            labelConfirm.TabIndex = 4;
            labelConfirm.Text = "Подтверждение";
            // 
            // ChangePasswordDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 238);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtConfirm);
            Controls.Add(labelConfirm);
            Controls.Add(txtNew);
            Controls.Add(labelNew);
            Controls.Add(txtCurrent);
            Controls.Add(labelCurrent);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.Label labelConfirm;
    }
}