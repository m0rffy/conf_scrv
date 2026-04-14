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
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Location = new Point(53, 13);
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
            btnOk.BackColor = Color.LightSkyBlue;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Times New Roman", 12F);
            btnOk.ForeColor = Color.Black;
            btnOk.Location = new Point(53, 111);
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
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(157, 110);
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
            labelHour.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelHour.Location = new Point(84, 47);
            labelHour.Margin = new Padding(4, 0, 4, 0);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(47, 19);
            labelHour.TabIndex = 1;
            labelHour.Text = "Часы:";
            labelHour.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownHour
            // 
            numericUpDownHour.Anchor = AnchorStyles.None;
            numericUpDownHour.AutoSize = true;
            numericUpDownHour.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownHour.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownHour.Location = new Point(134, 44);
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
            labelMinute.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMinute.Location = new Point(62, 79);
            labelMinute.Margin = new Padding(4, 0, 4, 0);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(69, 19);
            labelMinute.TabIndex = 3;
            labelMinute.Text = "Минуты:";
            // 
            // numericUpDownMinute
            // 
            numericUpDownMinute.Anchor = AnchorStyles.None;
            numericUpDownMinute.AutoSize = true;
            numericUpDownMinute.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownMinute.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownMinute.Location = new Point(134, 76);
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
            BackColor = Color.LightGray;
            ClientSize = new Size(283, 161);
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