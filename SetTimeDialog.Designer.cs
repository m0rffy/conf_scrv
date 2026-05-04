namespace Uetm_2_0
{
    partial class SetTimeDialog
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
            dateTimePicker1 = new DateTimePicker();
            btnOk = new RoundedButton();
            btnCancel = new RoundedButton();
            labelHour = new Label();
            numericUpDownHour = new NumericUpDown();
            labelMinute = new Label();
            numericUpDownMinute = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Location = new Point(54, 27);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(177, 26);
            dateTimePicker1.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.None;
            btnOk.AutoSize = true;
            btnOk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOk.BackColor = Color.SkyBlue;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Times New Roman", 12F);
            btnOk.ForeColor = Color.Black;
            btnOk.Location = new Point(54, 154);
            btnOk.Margin = new Padding(4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(96, 29);
            btnOk.TabIndex = 5;
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
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(158, 153);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(73, 31);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // labelHour
            // 
            labelHour.Anchor = AnchorStyles.None;
            labelHour.AutoSize = true;
            labelHour.BackColor = Color.Transparent;
            labelHour.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelHour.Location = new Point(54, 63);
            labelHour.Margin = new Padding(4, 0, 4, 0);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(44, 19);
            labelHour.TabIndex = 1;
            labelHour.Text = "Часы";
            labelHour.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownHour
            // 
            numericUpDownHour.Anchor = AnchorStyles.None;
            numericUpDownHour.AutoSize = true;
            numericUpDownHour.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownHour.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownHour.Location = new Point(181, 60);
            numericUpDownHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownHour.Name = "numericUpDownHour";
            numericUpDownHour.Size = new Size(50, 26);
            numericUpDownHour.TabIndex = 2;
            numericUpDownHour.TextAlign = HorizontalAlignment.Center;
            // 
            // labelMinute
            // 
            labelMinute.Anchor = AnchorStyles.None;
            labelMinute.AutoSize = true;
            labelMinute.BackColor = Color.Transparent;
            labelMinute.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMinute.Location = new Point(54, 104);
            labelMinute.Margin = new Padding(4, 0, 4, 0);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(66, 19);
            labelMinute.TabIndex = 3;
            labelMinute.Text = "Минуты";
            labelMinute.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownMinute
            // 
            numericUpDownMinute.Anchor = AnchorStyles.None;
            numericUpDownMinute.AutoSize = true;
            numericUpDownMinute.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownMinute.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownMinute.Location = new Point(181, 102);
            numericUpDownMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownMinute.Name = "numericUpDownMinute";
            numericUpDownMinute.Size = new Size(50, 26);
            numericUpDownMinute.TabIndex = 4;
            numericUpDownMinute.TextAlign = HorizontalAlignment.Center;
            // 
            // SetTimeDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            ClientSize = new Size(284, 211);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(numericUpDownMinute);
            Controls.Add(labelMinute);
            Controls.Add(numericUpDownHour);
            Controls.Add(labelHour);
            Controls.Add(dateTimePicker1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SetTimeDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выберите дату и время";
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
    }
}