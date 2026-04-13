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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetTimeDialog));
            dateTimePicker1 = new DateTimePicker();
            btnOk = new Button();
            btnCancel = new Button();
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
            dateTimePicker1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Location = new Point(24, 29);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 29);
            dateTimePicker1.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.None;
            btnOk.AutoSize = true;
            btnOk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOk.BackColor = Color.LightSkyBlue;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Times New Roman", 12F);
            btnOk.Location = new Point(24, 111);
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
            btnCancel.BackColor = Color.LightSkyBlue;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Times New Roman", 12F);
            btnCancel.Location = new Point(211, 111);
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
            labelHour.Font = new Font("Times New Roman", 14.25F);
            labelHour.Location = new Point(24, 70);
            labelHour.Margin = new Padding(4, 0, 4, 0);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(56, 21);
            labelHour.TabIndex = 1;
            labelHour.Text = "Часы:";
            labelHour.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownHour
            // 
            numericUpDownHour.Anchor = AnchorStyles.None;
            numericUpDownHour.AutoSize = true;
            numericUpDownHour.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownHour.Font = new Font("Times New Roman", 14.25F);
            numericUpDownHour.Location = new Point(88, 65);
            numericUpDownHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownHour.Name = "numericUpDownHour";
            numericUpDownHour.Size = new Size(50, 29);
            numericUpDownHour.TabIndex = 2;
            numericUpDownHour.TextAlign = HorizontalAlignment.Center;
            // 
            // labelMinute
            // 
            labelMinute.Anchor = AnchorStyles.None;
            labelMinute.AutoSize = true;
            labelMinute.Font = new Font("Times New Roman", 14.25F);
            labelMinute.Location = new Point(145, 70);
            labelMinute.Margin = new Padding(4, 0, 4, 0);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(80, 21);
            labelMinute.TabIndex = 3;
            labelMinute.Text = "Минуты:";
            // 
            // numericUpDownMinute
            // 
            numericUpDownMinute.Anchor = AnchorStyles.None;
            numericUpDownMinute.AutoSize = true;
            numericUpDownMinute.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownMinute.Font = new Font("Times New Roman", 14.25F);
            numericUpDownMinute.Location = new Point(232, 64);
            numericUpDownMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownMinute.Name = "numericUpDownMinute";
            numericUpDownMinute.Size = new Size(50, 29);
            numericUpDownMinute.TabIndex = 4;
            numericUpDownMinute.TextAlign = HorizontalAlignment.Center;
            // 
            // SetTimeDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightGray;
            ClientSize = new Size(306, 161);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(numericUpDownMinute);
            Controls.Add(labelMinute);
            Controls.Add(numericUpDownHour);
            Controls.Add(labelHour);
            Controls.Add(dateTimePicker1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(400, 200);
            MinimizeBox = false;
            Name = "SetTimeDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выберите дату и время";
            Load += SetTimeDialog_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;

        private void SetTimeDialog_Load(object sender, EventArgs e)
        {

        }
    }
}