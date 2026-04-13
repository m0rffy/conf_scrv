namespace Uetm_2_0
{
    partial class UcGeneral
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanelMain = new TableLayoutPanel();
            groupBoxBreakerInfo = new GroupBox();
            tableLayoutBreakerInfo = new TableLayoutPanel();
            labelSwitchType = new Label();
            switchTypeComboBox = new ComboBox();
            labelNominalCurrent = new Label();
            nominalCurrentTextBox = new TextBox();
            labelMaxCurrent = new Label();
            maxCurrentTextBox = new TextBox();
            groupBoxCoefficients = new GroupBox();
            tableLayoutCoefficients = new TableLayoutPanel();
            c1TextBox = new TextBox();
            c4TextBox = new TextBox();
            labelC1 = new Label();
            c3TextBox = new TextBox();
            c2TextBox = new TextBox();
            labelC2 = new Label();
            labelC3 = new Label();
            labelC4 = new Label();
            groupBoxDelay = new GroupBox();
            delayDataGridView = new DataGridView();
            groupBoxAlgorithm = new GroupBox();
            tableLayoutAlgorithm = new TableLayoutPanel();
            thresholdCurrentTextBox = new TextBox();
            labelThresholdCurrent = new Label();
            labelNominalOperations = new Label();
            nominalOperationsTextBox = new TextBox();
            warningThresholdTextBox = new TextBox();
            labelWarningThreshold = new Label();
            labelAlarmThreshold = new Label();
            alarmThresholdTextBox = new TextBox();
            groupBoxInstallation = new GroupBox();
            tableLayoutInstallation = new TableLayoutPanel();
            switchModelTextBox = new TextBox();
            labelInstallationPlace = new Label();
            installationPlaceTextBox = new TextBox();
            labelSwitchLabel = new Label();
            switchLabelTextBox = new TextBox();
            label1 = new Label();
            groupBoxPrimaryCT = new GroupBox();
            tableLayoutPrimaryCT = new TableLayoutPanel();
            secondaryCurrentTextBox = new TextBox();
            labelPrimaryCurrent = new Label();
            primaryCurrentTextBox = new TextBox();
            labelSecondaryCurrent = new Label();
            groupBoxDebounce = new GroupBox();
            tableLayoutDebounce = new TableLayoutPanel();
            debounceOnTextBox = new TextBox();
            debounceOffTextBox = new TextBox();
            labelDebounceOff = new Label();
            labelDebounceOn = new Label();
            tableLayoutPanelMain.SuspendLayout();
            groupBoxBreakerInfo.SuspendLayout();
            tableLayoutBreakerInfo.SuspendLayout();
            groupBoxCoefficients.SuspendLayout();
            tableLayoutCoefficients.SuspendLayout();
            groupBoxDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)delayDataGridView).BeginInit();
            groupBoxAlgorithm.SuspendLayout();
            tableLayoutAlgorithm.SuspendLayout();
            groupBoxInstallation.SuspendLayout();
            tableLayoutInstallation.SuspendLayout();
            groupBoxPrimaryCT.SuspendLayout();
            tableLayoutPrimaryCT.SuspendLayout();
            groupBoxDebounce.SuspendLayout();
            tableLayoutDebounce.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.Anchor = AnchorStyles.None;
            tableLayoutPanelMain.AutoScroll = true;
            tableLayoutPanelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.Controls.Add(groupBoxBreakerInfo, 0, 0);
            tableLayoutPanelMain.Controls.Add(groupBoxCoefficients, 1, 1);
            tableLayoutPanelMain.Controls.Add(groupBoxDelay, 0, 4);
            tableLayoutPanelMain.Controls.Add(groupBoxAlgorithm, 0, 1);
            tableLayoutPanelMain.Controls.Add(groupBoxInstallation, 1, 0);
            tableLayoutPanelMain.Controls.Add(groupBoxPrimaryCT, 1, 2);
            tableLayoutPanelMain.Controls.Add(groupBoxDebounce, 0, 2);
            tableLayoutPanelMain.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableLayoutPanelMain.Location = new Point(13, 17);
            tableLayoutPanelMain.Margin = new Padding(4);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 5;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanelMain.Size = new Size(1118, 673);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxBreakerInfo
            // 
            groupBoxBreakerInfo.Anchor = AnchorStyles.None;
            groupBoxBreakerInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxBreakerInfo.Controls.Add(tableLayoutBreakerInfo);
            groupBoxBreakerInfo.Font = new Font("Times New Roman", 14F);
            groupBoxBreakerInfo.Location = new Point(13, 5);
            groupBoxBreakerInfo.Margin = new Padding(4);
            groupBoxBreakerInfo.Name = "groupBoxBreakerInfo";
            groupBoxBreakerInfo.Padding = new Padding(4);
            groupBoxBreakerInfo.Size = new Size(526, 144);
            groupBoxBreakerInfo.TabIndex = 0;
            groupBoxBreakerInfo.TabStop = false;
            groupBoxBreakerInfo.Text = "Информация о выключателе";
            // 
            // tableLayoutBreakerInfo
            // 
            tableLayoutBreakerInfo.Anchor = AnchorStyles.None;
            tableLayoutBreakerInfo.AutoSize = true;
            tableLayoutBreakerInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutBreakerInfo.ColumnCount = 2;
            tableLayoutBreakerInfo.ColumnStyles.Add(new ColumnStyle());
            tableLayoutBreakerInfo.ColumnStyles.Add(new ColumnStyle());
            tableLayoutBreakerInfo.Controls.Add(labelSwitchType, 0, 2);
            tableLayoutBreakerInfo.Controls.Add(switchTypeComboBox, 1, 2);
            tableLayoutBreakerInfo.Controls.Add(labelNominalCurrent, 0, 3);
            tableLayoutBreakerInfo.Controls.Add(nominalCurrentTextBox, 1, 3);
            tableLayoutBreakerInfo.Controls.Add(labelMaxCurrent, 0, 4);
            tableLayoutBreakerInfo.Controls.Add(maxCurrentTextBox, 1, 4);
            tableLayoutBreakerInfo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableLayoutBreakerInfo.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutBreakerInfo.Location = new Point(23, 31);
            tableLayoutBreakerInfo.Margin = new Padding(4);
            tableLayoutBreakerInfo.Name = "tableLayoutBreakerInfo";
            tableLayoutBreakerInfo.RowCount = 5;
            tableLayoutBreakerInfo.RowStyles.Add(new RowStyle());
            tableLayoutBreakerInfo.RowStyles.Add(new RowStyle());
            tableLayoutBreakerInfo.RowStyles.Add(new RowStyle());
            tableLayoutBreakerInfo.RowStyles.Add(new RowStyle());
            tableLayoutBreakerInfo.RowStyles.Add(new RowStyle());
            tableLayoutBreakerInfo.Size = new Size(497, 103);
            tableLayoutBreakerInfo.TabIndex = 0;
            // 
            // labelSwitchType
            // 
            labelSwitchType.Anchor = AnchorStyles.Left;
            labelSwitchType.AutoSize = true;
            labelSwitchType.Location = new Point(4, 8);
            labelSwitchType.Margin = new Padding(4, 0, 4, 0);
            labelSwitchType.Name = "labelSwitchType";
            labelSwitchType.Size = new Size(132, 19);
            labelSwitchType.TabIndex = 4;
            labelSwitchType.Text = "Тип выключателя:";
            // 
            // switchTypeComboBox
            // 
            switchTypeComboBox.Anchor = AnchorStyles.None;
            switchTypeComboBox.BackColor = Color.LightGray;
            switchTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            switchTypeComboBox.Items.AddRange(new object[] { "ВГТ-35", "ВГТ-110", "ВЭБ-110", "ВГТ-220", "ВГТ-330", "ВГТ-750", "ВГК-500", "ВГТ-1А1-220-40-3150", "ВЭБ-220-50", "ВГБ-35-12,5-С1", "ВГБ-35-12,5-С2", "ВГТ-500-40-3150", "ВГТ-500-50-3150", "Пользовательский" });
            switchTypeComboBox.Location = new Point(314, 4);
            switchTypeComboBox.Margin = new Padding(4);
            switchTypeComboBox.Name = "switchTypeComboBox";
            switchTypeComboBox.Size = new Size(178, 27);
            switchTypeComboBox.TabIndex = 5;
            // 
            // labelNominalCurrent
            // 
            labelNominalCurrent.Anchor = AnchorStyles.Left;
            labelNominalCurrent.AutoSize = true;
            labelNominalCurrent.Font = new Font("Times New Roman", 12F);
            labelNominalCurrent.Location = new Point(4, 42);
            labelNominalCurrent.Margin = new Padding(4, 0, 4, 0);
            labelNominalCurrent.Name = "labelNominalCurrent";
            labelNominalCurrent.Size = new Size(155, 19);
            labelNominalCurrent.TabIndex = 0;
            labelNominalCurrent.Text = "Номинальный ток, А:";
            // 
            // nominalCurrentTextBox
            // 
            nominalCurrentTextBox.Anchor = AnchorStyles.None;
            nominalCurrentTextBox.Location = new Point(314, 39);
            nominalCurrentTextBox.Margin = new Padding(4);
            nominalCurrentTextBox.Name = "nominalCurrentTextBox";
            nominalCurrentTextBox.Size = new Size(179, 26);
            nominalCurrentTextBox.TabIndex = 1;
            nominalCurrentTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelMaxCurrent
            // 
            labelMaxCurrent.Anchor = AnchorStyles.Left;
            labelMaxCurrent.Font = new Font("Times New Roman", 12F);
            labelMaxCurrent.Location = new Point(4, 75);
            labelMaxCurrent.Margin = new Padding(4, 0, 4, 0);
            labelMaxCurrent.Name = "labelMaxCurrent";
            labelMaxCurrent.Size = new Size(302, 22);
            labelMaxCurrent.TabIndex = 2;
            labelMaxCurrent.Text = "Номинальный ток отключения, кА:";
            // 
            // maxCurrentTextBox
            // 
            maxCurrentTextBox.Anchor = AnchorStyles.None;
            maxCurrentTextBox.Location = new Point(315, 73);
            maxCurrentTextBox.Margin = new Padding(4);
            maxCurrentTextBox.Name = "maxCurrentTextBox";
            maxCurrentTextBox.Size = new Size(176, 26);
            maxCurrentTextBox.TabIndex = 3;
            maxCurrentTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBoxCoefficients
            // 
            groupBoxCoefficients.Anchor = AnchorStyles.None;
            groupBoxCoefficients.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxCoefficients.Controls.Add(tableLayoutCoefficients);
            groupBoxCoefficients.Font = new Font("Times New Roman", 14F);
            groupBoxCoefficients.Location = new Point(565, 164);
            groupBoxCoefficients.Margin = new Padding(4);
            groupBoxCoefficients.Name = "groupBoxCoefficients";
            groupBoxCoefficients.Padding = new Padding(4);
            groupBoxCoefficients.Size = new Size(540, 168);
            groupBoxCoefficients.TabIndex = 3;
            groupBoxCoefficients.TabStop = false;
            groupBoxCoefficients.Text = "Коэффициенты полинома аппроксимации";
            // 
            // tableLayoutCoefficients
            // 
            tableLayoutCoefficients.AutoSize = true;
            tableLayoutCoefficients.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutCoefficients.ColumnCount = 4;
            tableLayoutCoefficients.ColumnStyles.Add(new ColumnStyle());
            tableLayoutCoefficients.ColumnStyles.Add(new ColumnStyle());
            tableLayoutCoefficients.ColumnStyles.Add(new ColumnStyle());
            tableLayoutCoefficients.ColumnStyles.Add(new ColumnStyle());
            tableLayoutCoefficients.Controls.Add(c1TextBox, 0, 1);
            tableLayoutCoefficients.Controls.Add(c4TextBox, 3, 1);
            tableLayoutCoefficients.Controls.Add(labelC1, 0, 0);
            tableLayoutCoefficients.Controls.Add(c3TextBox, 2, 1);
            tableLayoutCoefficients.Controls.Add(c2TextBox, 1, 1);
            tableLayoutCoefficients.Controls.Add(labelC2, 1, 0);
            tableLayoutCoefficients.Controls.Add(labelC3, 2, 0);
            tableLayoutCoefficients.Controls.Add(labelC4, 3, 0);
            tableLayoutCoefficients.Font = new Font("Times New Roman", 12F);
            tableLayoutCoefficients.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutCoefficients.Location = new Point(12, 63);
            tableLayoutCoefficients.Margin = new Padding(4);
            tableLayoutCoefficients.Name = "tableLayoutCoefficients";
            tableLayoutCoefficients.RowCount = 2;
            tableLayoutCoefficients.RowStyles.Add(new RowStyle());
            tableLayoutCoefficients.RowStyles.Add(new RowStyle());
            tableLayoutCoefficients.Size = new Size(512, 51);
            tableLayoutCoefficients.TabIndex = 0;
            // 
            // c1TextBox
            // 
            c1TextBox.Anchor = AnchorStyles.None;
            c1TextBox.Location = new Point(3, 22);
            c1TextBox.Name = "c1TextBox";
            c1TextBox.Size = new Size(122, 26);
            c1TextBox.TabIndex = 1;
            c1TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // c4TextBox
            // 
            c4TextBox.Anchor = AnchorStyles.None;
            c4TextBox.Location = new Point(387, 22);
            c4TextBox.Name = "c4TextBox";
            c4TextBox.Size = new Size(122, 26);
            c4TextBox.TabIndex = 3;
            c4TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelC1
            // 
            labelC1.Anchor = AnchorStyles.None;
            labelC1.AutoSize = true;
            labelC1.Location = new Point(48, 0);
            labelC1.Margin = new Padding(4, 0, 4, 0);
            labelC1.Name = "labelC1";
            labelC1.Size = new Size(31, 19);
            labelC1.TabIndex = 0;
            labelC1.Text = "C1:";
            // 
            // c3TextBox
            // 
            c3TextBox.Anchor = AnchorStyles.None;
            c3TextBox.Location = new Point(259, 22);
            c3TextBox.Name = "c3TextBox";
            c3TextBox.Size = new Size(122, 26);
            c3TextBox.TabIndex = 2;
            c3TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // c2TextBox
            // 
            c2TextBox.Anchor = AnchorStyles.None;
            c2TextBox.Location = new Point(131, 22);
            c2TextBox.Name = "c2TextBox";
            c2TextBox.Size = new Size(122, 26);
            c2TextBox.TabIndex = 1;
            c2TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelC2
            // 
            labelC2.Anchor = AnchorStyles.None;
            labelC2.AutoSize = true;
            labelC2.Location = new Point(176, 0);
            labelC2.Margin = new Padding(4, 0, 4, 0);
            labelC2.Name = "labelC2";
            labelC2.Size = new Size(31, 19);
            labelC2.TabIndex = 2;
            labelC2.Text = "C2:";
            // 
            // labelC3
            // 
            labelC3.Anchor = AnchorStyles.None;
            labelC3.AutoSize = true;
            labelC3.Location = new Point(304, 0);
            labelC3.Margin = new Padding(4, 0, 4, 0);
            labelC3.Name = "labelC3";
            labelC3.Size = new Size(31, 19);
            labelC3.TabIndex = 4;
            labelC3.Text = "C3:";
            // 
            // labelC4
            // 
            labelC4.Anchor = AnchorStyles.None;
            labelC4.AutoSize = true;
            labelC4.Location = new Point(432, 0);
            labelC4.Margin = new Padding(4, 0, 4, 0);
            labelC4.Name = "labelC4";
            labelC4.Size = new Size(31, 19);
            labelC4.TabIndex = 6;
            labelC4.Text = "C4:";
            // 
            // groupBoxDelay
            // 
            groupBoxDelay.Anchor = AnchorStyles.None;
            groupBoxDelay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelMain.SetColumnSpan(groupBoxDelay, 2);
            groupBoxDelay.Controls.Add(delayDataGridView);
            groupBoxDelay.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxDelay.Location = new Point(153, 486);
            groupBoxDelay.Margin = new Padding(4);
            groupBoxDelay.Name = "groupBoxDelay";
            groupBoxDelay.Padding = new Padding(4);
            groupBoxDelay.Size = new Size(812, 175);
            groupBoxDelay.TabIndex = 6;
            groupBoxDelay.TabStop = false;
            groupBoxDelay.Text = "Запаздывание/опережение срабатывания вспомогательного контакта относительно главного, мс";
            // 
            // delayDataGridView
            // 
            delayDataGridView.AllowUserToAddRows = false;
            delayDataGridView.AllowUserToDeleteRows = false;
            delayDataGridView.Anchor = AnchorStyles.None;
            delayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            delayDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            delayDataGridView.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            delayDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            delayDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            delayDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            delayDataGridView.GridColor = Color.LightGray;
            delayDataGridView.Location = new Point(40, 37);
            delayDataGridView.Margin = new Padding(4);
            delayDataGridView.Name = "delayDataGridView";
            delayDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            delayDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            delayDataGridView.RowHeadersVisible = false;
            delayDataGridView.RowHeadersWidth = 40;
            delayDataGridView.ScrollBars = ScrollBars.None;
            delayDataGridView.Size = new Size(727, 124);
            delayDataGridView.TabIndex = 0;
            // 
            // groupBoxAlgorithm
            // 
            groupBoxAlgorithm.Anchor = AnchorStyles.None;
            groupBoxAlgorithm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxAlgorithm.Controls.Add(tableLayoutAlgorithm);
            groupBoxAlgorithm.Font = new Font("Times New Roman", 14F);
            groupBoxAlgorithm.Location = new Point(4, 158);
            groupBoxAlgorithm.Margin = new Padding(4);
            groupBoxAlgorithm.Name = "groupBoxAlgorithm";
            groupBoxAlgorithm.Padding = new Padding(4);
            groupBoxAlgorithm.Size = new Size(544, 180);
            groupBoxAlgorithm.TabIndex = 1;
            groupBoxAlgorithm.TabStop = false;
            groupBoxAlgorithm.Text = "Настройка алгоритма расчета";
            // 
            // tableLayoutAlgorithm
            // 
            tableLayoutAlgorithm.AutoSize = true;
            tableLayoutAlgorithm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutAlgorithm.ColumnCount = 2;
            tableLayoutAlgorithm.ColumnStyles.Add(new ColumnStyle());
            tableLayoutAlgorithm.ColumnStyles.Add(new ColumnStyle());
            tableLayoutAlgorithm.Controls.Add(thresholdCurrentTextBox, 1, 0);
            tableLayoutAlgorithm.Controls.Add(labelThresholdCurrent, 0, 0);
            tableLayoutAlgorithm.Controls.Add(labelNominalOperations, 0, 1);
            tableLayoutAlgorithm.Controls.Add(nominalOperationsTextBox, 1, 1);
            tableLayoutAlgorithm.Controls.Add(warningThresholdTextBox, 1, 2);
            tableLayoutAlgorithm.Controls.Add(labelWarningThreshold, 0, 2);
            tableLayoutAlgorithm.Controls.Add(labelAlarmThreshold, 0, 3);
            tableLayoutAlgorithm.Controls.Add(alarmThresholdTextBox, 1, 3);
            tableLayoutAlgorithm.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableLayoutAlgorithm.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutAlgorithm.Location = new Point(20, 30);
            tableLayoutAlgorithm.Margin = new Padding(4);
            tableLayoutAlgorithm.Name = "tableLayoutAlgorithm";
            tableLayoutAlgorithm.RowCount = 4;
            tableLayoutAlgorithm.RowStyles.Add(new RowStyle());
            tableLayoutAlgorithm.RowStyles.Add(new RowStyle());
            tableLayoutAlgorithm.RowStyles.Add(new RowStyle());
            tableLayoutAlgorithm.RowStyles.Add(new RowStyle());
            tableLayoutAlgorithm.Size = new Size(518, 136);
            tableLayoutAlgorithm.TabIndex = 0;
            // 
            // thresholdCurrentTextBox
            // 
            thresholdCurrentTextBox.Anchor = AnchorStyles.None;
            thresholdCurrentTextBox.Location = new Point(401, 4);
            thresholdCurrentTextBox.Margin = new Padding(4);
            thresholdCurrentTextBox.Name = "thresholdCurrentTextBox";
            thresholdCurrentTextBox.Size = new Size(112, 26);
            thresholdCurrentTextBox.TabIndex = 1;
            thresholdCurrentTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelThresholdCurrent
            // 
            labelThresholdCurrent.Anchor = AnchorStyles.Left;
            labelThresholdCurrent.AutoSize = true;
            labelThresholdCurrent.Location = new Point(4, 7);
            labelThresholdCurrent.Margin = new Padding(4, 0, 4, 0);
            labelThresholdCurrent.Name = "labelThresholdCurrent";
            labelThresholdCurrent.Size = new Size(388, 19);
            labelThresholdCurrent.TabIndex = 0;
            labelThresholdCurrent.Text = "Ток порога нечувствительности первичного датчика, А:";
            labelThresholdCurrent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNominalOperations
            // 
            labelNominalOperations.Anchor = AnchorStyles.Left;
            labelNominalOperations.AutoSize = true;
            labelNominalOperations.Location = new Point(4, 41);
            labelNominalOperations.Margin = new Padding(4, 0, 4, 0);
            labelNominalOperations.Name = "labelNominalOperations";
            labelNominalOperations.Size = new Size(191, 19);
            labelNominalOperations.TabIndex = 2;
            labelNominalOperations.Text = "Номинальное кол-во откл.:";
            // 
            // nominalOperationsTextBox
            // 
            nominalOperationsTextBox.Anchor = AnchorStyles.None;
            nominalOperationsTextBox.Location = new Point(401, 38);
            nominalOperationsTextBox.Margin = new Padding(4);
            nominalOperationsTextBox.Name = "nominalOperationsTextBox";
            nominalOperationsTextBox.Size = new Size(112, 26);
            nominalOperationsTextBox.TabIndex = 3;
            nominalOperationsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // warningThresholdTextBox
            // 
            warningThresholdTextBox.Anchor = AnchorStyles.None;
            warningThresholdTextBox.Enabled = false;
            warningThresholdTextBox.Location = new Point(400, 72);
            warningThresholdTextBox.Margin = new Padding(4);
            warningThresholdTextBox.Name = "warningThresholdTextBox";
            warningThresholdTextBox.ReadOnly = true;
            warningThresholdTextBox.Size = new Size(114, 26);
            warningThresholdTextBox.TabIndex = 7;
            warningThresholdTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelWarningThreshold
            // 
            labelWarningThreshold.Anchor = AnchorStyles.Left;
            labelWarningThreshold.AutoSize = true;
            labelWarningThreshold.Font = new Font("Times New Roman", 12F);
            labelWarningThreshold.Location = new Point(4, 75);
            labelWarningThreshold.Margin = new Padding(4, 0, 4, 0);
            labelWarningThreshold.Name = "labelWarningThreshold";
            labelWarningThreshold.Size = new Size(237, 19);
            labelWarningThreshold.TabIndex = 6;
            labelWarningThreshold.Text = "Порог предупр. сигнализации, %:";
            // 
            // labelAlarmThreshold
            // 
            labelAlarmThreshold.Anchor = AnchorStyles.Left;
            labelAlarmThreshold.AutoSize = true;
            labelAlarmThreshold.Font = new Font("Times New Roman", 12F);
            labelAlarmThreshold.Location = new Point(4, 109);
            labelAlarmThreshold.Margin = new Padding(4, 0, 4, 0);
            labelAlarmThreshold.Name = "labelAlarmThreshold";
            labelAlarmThreshold.Size = new Size(251, 19);
            labelAlarmThreshold.TabIndex = 8;
            labelAlarmThreshold.Text = "Порог аварийной сигнализации, %:";
            // 
            // alarmThresholdTextBox
            // 
            alarmThresholdTextBox.Anchor = AnchorStyles.None;
            alarmThresholdTextBox.Enabled = false;
            alarmThresholdTextBox.Location = new Point(400, 106);
            alarmThresholdTextBox.Margin = new Padding(4);
            alarmThresholdTextBox.Name = "alarmThresholdTextBox";
            alarmThresholdTextBox.ReadOnly = true;
            alarmThresholdTextBox.Size = new Size(114, 26);
            alarmThresholdTextBox.TabIndex = 9;
            alarmThresholdTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBoxInstallation
            // 
            groupBoxInstallation.Anchor = AnchorStyles.None;
            groupBoxInstallation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxInstallation.Controls.Add(tableLayoutInstallation);
            groupBoxInstallation.Font = new Font("Times New Roman", 14F);
            groupBoxInstallation.Location = new Point(570, 4);
            groupBoxInstallation.Margin = new Padding(4);
            groupBoxInstallation.Name = "groupBoxInstallation";
            groupBoxInstallation.Padding = new Padding(4);
            groupBoxInstallation.Size = new Size(529, 146);
            groupBoxInstallation.TabIndex = 2;
            groupBoxInstallation.TabStop = false;
            groupBoxInstallation.Text = "Место установки";
            // 
            // tableLayoutInstallation
            // 
            tableLayoutInstallation.AutoSize = true;
            tableLayoutInstallation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutInstallation.ColumnCount = 2;
            tableLayoutInstallation.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInstallation.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInstallation.Controls.Add(switchModelTextBox, 1, 1);
            tableLayoutInstallation.Controls.Add(labelInstallationPlace, 0, 0);
            tableLayoutInstallation.Controls.Add(installationPlaceTextBox, 1, 0);
            tableLayoutInstallation.Controls.Add(labelSwitchLabel, 0, 2);
            tableLayoutInstallation.Controls.Add(switchLabelTextBox, 1, 2);
            tableLayoutInstallation.Controls.Add(label1, 0, 1);
            tableLayoutInstallation.Font = new Font("Times New Roman", 12F);
            tableLayoutInstallation.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutInstallation.Location = new Point(17, 31);
            tableLayoutInstallation.Margin = new Padding(4);
            tableLayoutInstallation.Name = "tableLayoutInstallation";
            tableLayoutInstallation.RowCount = 3;
            tableLayoutInstallation.RowStyles.Add(new RowStyle());
            tableLayoutInstallation.RowStyles.Add(new RowStyle());
            tableLayoutInstallation.RowStyles.Add(new RowStyle());
            tableLayoutInstallation.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutInstallation.Size = new Size(496, 100);
            tableLayoutInstallation.TabIndex = 0;
            // 
            // switchModelTextBox
            // 
            switchModelTextBox.Anchor = AnchorStyles.None;
            switchModelTextBox.Location = new Point(245, 37);
            switchModelTextBox.Name = "switchModelTextBox";
            switchModelTextBox.Size = new Size(247, 26);
            switchModelTextBox.TabIndex = 1;
            switchModelTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelInstallationPlace
            // 
            labelInstallationPlace.Anchor = AnchorStyles.Left;
            labelInstallationPlace.AutoSize = true;
            labelInstallationPlace.Location = new Point(4, 7);
            labelInstallationPlace.Margin = new Padding(4, 0, 4, 0);
            labelInstallationPlace.Name = "labelInstallationPlace";
            labelInstallationPlace.Size = new Size(128, 19);
            labelInstallationPlace.TabIndex = 2;
            labelInstallationPlace.Text = "Место установки:";
            // 
            // installationPlaceTextBox
            // 
            installationPlaceTextBox.Anchor = AnchorStyles.None;
            installationPlaceTextBox.BorderStyle = BorderStyle.FixedSingle;
            installationPlaceTextBox.Location = new Point(246, 4);
            installationPlaceTextBox.Margin = new Padding(4);
            installationPlaceTextBox.Name = "installationPlaceTextBox";
            installationPlaceTextBox.Size = new Size(245, 26);
            installationPlaceTextBox.TabIndex = 3;
            installationPlaceTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelSwitchLabel
            // 
            labelSwitchLabel.Anchor = AnchorStyles.Left;
            labelSwitchLabel.AutoSize = true;
            labelSwitchLabel.Location = new Point(4, 73);
            labelSwitchLabel.Margin = new Padding(4, 0, 4, 0);
            labelSwitchLabel.Name = "labelSwitchLabel";
            labelSwitchLabel.Size = new Size(233, 19);
            labelSwitchLabel.TabIndex = 6;
            labelSwitchLabel.Text = "Обозначение выключателя схеме";
            // 
            // switchLabelTextBox
            // 
            switchLabelTextBox.Anchor = AnchorStyles.None;
            switchLabelTextBox.Location = new Point(245, 70);
            switchLabelTextBox.Margin = new Padding(4);
            switchLabelTextBox.Name = "switchLabelTextBox";
            switchLabelTextBox.Size = new Size(247, 26);
            switchLabelTextBox.TabIndex = 7;
            switchLabelTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(94, 19);
            label1.TabIndex = 1;
            label1.Text = "Тип изделия";
            // 
            // groupBoxPrimaryCT
            // 
            groupBoxPrimaryCT.Anchor = AnchorStyles.None;
            groupBoxPrimaryCT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxPrimaryCT.Controls.Add(tableLayoutPrimaryCT);
            groupBoxPrimaryCT.Font = new Font("Times New Roman", 14F);
            groupBoxPrimaryCT.Location = new Point(566, 351);
            groupBoxPrimaryCT.Margin = new Padding(4);
            groupBoxPrimaryCT.Name = "groupBoxPrimaryCT";
            groupBoxPrimaryCT.Padding = new Padding(4);
            groupBoxPrimaryCT.Size = new Size(538, 114);
            groupBoxPrimaryCT.TabIndex = 4;
            groupBoxPrimaryCT.TabStop = false;
            groupBoxPrimaryCT.Text = "Первичный датчик (трансформатор тока)";
            // 
            // tableLayoutPrimaryCT
            // 
            tableLayoutPrimaryCT.AutoSize = true;
            tableLayoutPrimaryCT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPrimaryCT.ColumnCount = 2;
            tableLayoutPrimaryCT.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPrimaryCT.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPrimaryCT.Controls.Add(secondaryCurrentTextBox, 1, 1);
            tableLayoutPrimaryCT.Controls.Add(labelPrimaryCurrent, 0, 0);
            tableLayoutPrimaryCT.Controls.Add(primaryCurrentTextBox, 1, 0);
            tableLayoutPrimaryCT.Controls.Add(labelSecondaryCurrent, 0, 1);
            tableLayoutPrimaryCT.Font = new Font("Times New Roman", 12F);
            tableLayoutPrimaryCT.Location = new Point(88, 31);
            tableLayoutPrimaryCT.Margin = new Padding(4);
            tableLayoutPrimaryCT.Name = "tableLayoutPrimaryCT";
            tableLayoutPrimaryCT.RowCount = 2;
            tableLayoutPrimaryCT.RowStyles.Add(new RowStyle());
            tableLayoutPrimaryCT.RowStyles.Add(new RowStyle());
            tableLayoutPrimaryCT.Size = new Size(353, 68);
            tableLayoutPrimaryCT.TabIndex = 0;
            // 
            // secondaryCurrentTextBox
            // 
            secondaryCurrentTextBox.Anchor = AnchorStyles.None;
            secondaryCurrentTextBox.Location = new Point(249, 38);
            secondaryCurrentTextBox.Margin = new Padding(4);
            secondaryCurrentTextBox.Name = "secondaryCurrentTextBox";
            secondaryCurrentTextBox.Size = new Size(100, 26);
            secondaryCurrentTextBox.TabIndex = 7;
            secondaryCurrentTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPrimaryCurrent
            // 
            labelPrimaryCurrent.Anchor = AnchorStyles.Left;
            labelPrimaryCurrent.AutoSize = true;
            labelPrimaryCurrent.Location = new Point(4, 7);
            labelPrimaryCurrent.Margin = new Padding(4, 0, 4, 0);
            labelPrimaryCurrent.Name = "labelPrimaryCurrent";
            labelPrimaryCurrent.Size = new Size(237, 19);
            labelPrimaryCurrent.TabIndex = 0;
            labelPrimaryCurrent.Text = "Номинальный первичный ток, А:";
            // 
            // primaryCurrentTextBox
            // 
            primaryCurrentTextBox.Anchor = AnchorStyles.None;
            primaryCurrentTextBox.Location = new Point(249, 4);
            primaryCurrentTextBox.Margin = new Padding(4);
            primaryCurrentTextBox.Name = "primaryCurrentTextBox";
            primaryCurrentTextBox.Size = new Size(100, 26);
            primaryCurrentTextBox.TabIndex = 1;
            primaryCurrentTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelSecondaryCurrent
            // 
            labelSecondaryCurrent.Anchor = AnchorStyles.Left;
            labelSecondaryCurrent.AutoSize = true;
            labelSecondaryCurrent.Location = new Point(4, 41);
            labelSecondaryCurrent.Margin = new Padding(4, 0, 4, 0);
            labelSecondaryCurrent.Name = "labelSecondaryCurrent";
            labelSecondaryCurrent.Size = new Size(236, 19);
            labelSecondaryCurrent.TabIndex = 2;
            labelSecondaryCurrent.Text = "Номинальный вторичный ток, А:";
            // 
            // groupBoxDebounce
            // 
            groupBoxDebounce.Anchor = AnchorStyles.None;
            groupBoxDebounce.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxDebounce.Controls.Add(tableLayoutDebounce);
            groupBoxDebounce.Font = new Font("Times New Roman", 14F);
            groupBoxDebounce.Location = new Point(5, 346);
            groupBoxDebounce.Margin = new Padding(4);
            groupBoxDebounce.Name = "groupBoxDebounce";
            groupBoxDebounce.Padding = new Padding(4);
            groupBoxDebounce.Size = new Size(542, 124);
            groupBoxDebounce.TabIndex = 5;
            groupBoxDebounce.TabStop = false;
            groupBoxDebounce.Text = "Время защиты от дребезга вспомогательного контакта после обнаружения события, мс";
            // 
            // tableLayoutDebounce
            // 
            tableLayoutDebounce.AutoSize = true;
            tableLayoutDebounce.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutDebounce.ColumnCount = 2;
            tableLayoutDebounce.ColumnStyles.Add(new ColumnStyle());
            tableLayoutDebounce.ColumnStyles.Add(new ColumnStyle());
            tableLayoutDebounce.Controls.Add(debounceOnTextBox, 1, 1);
            tableLayoutDebounce.Controls.Add(debounceOffTextBox, 1, 0);
            tableLayoutDebounce.Controls.Add(labelDebounceOff, 0, 0);
            tableLayoutDebounce.Controls.Add(labelDebounceOn, 0, 1);
            tableLayoutDebounce.Font = new Font("Times New Roman", 12F);
            tableLayoutDebounce.Location = new Point(141, 48);
            tableLayoutDebounce.Margin = new Padding(4);
            tableLayoutDebounce.Name = "tableLayoutDebounce";
            tableLayoutDebounce.RowCount = 2;
            tableLayoutDebounce.RowStyles.Add(new RowStyle());
            tableLayoutDebounce.RowStyles.Add(new RowStyle());
            tableLayoutDebounce.Size = new Size(243, 68);
            tableLayoutDebounce.TabIndex = 0;
            // 
            // debounceOnTextBox
            // 
            debounceOnTextBox.Anchor = AnchorStyles.None;
            debounceOnTextBox.Location = new Point(139, 38);
            debounceOnTextBox.Margin = new Padding(4);
            debounceOnTextBox.Name = "debounceOnTextBox";
            debounceOnTextBox.Size = new Size(100, 26);
            debounceOnTextBox.TabIndex = 5;
            debounceOnTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // debounceOffTextBox
            // 
            debounceOffTextBox.Anchor = AnchorStyles.None;
            debounceOffTextBox.Location = new Point(139, 4);
            debounceOffTextBox.Margin = new Padding(4);
            debounceOffTextBox.Name = "debounceOffTextBox";
            debounceOffTextBox.Size = new Size(100, 26);
            debounceOffTextBox.TabIndex = 4;
            debounceOffTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelDebounceOff
            // 
            labelDebounceOff.Anchor = AnchorStyles.Left;
            labelDebounceOff.AutoSize = true;
            labelDebounceOff.Location = new Point(4, 7);
            labelDebounceOff.Margin = new Padding(4, 0, 4, 0);
            labelDebounceOff.Name = "labelDebounceOff";
            labelDebounceOff.Size = new Size(127, 19);
            labelDebounceOff.TabIndex = 0;
            labelDebounceOff.Text = "При отключении:";
            // 
            // labelDebounceOn
            // 
            labelDebounceOn.Anchor = AnchorStyles.Left;
            labelDebounceOn.AutoSize = true;
            labelDebounceOn.Location = new Point(4, 41);
            labelDebounceOn.Margin = new Padding(4, 0, 4, 0);
            labelDebounceOn.Name = "labelDebounceOn";
            labelDebounceOn.Size = new Size(120, 19);
            labelDebounceOn.TabIndex = 2;
            labelDebounceOn.Text = "При включении:";
            // 
            // UcGeneral
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanelMain);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "UcGeneral";
            Size = new Size(1145, 719);
            tableLayoutPanelMain.ResumeLayout(false);
            groupBoxBreakerInfo.ResumeLayout(false);
            groupBoxBreakerInfo.PerformLayout();
            tableLayoutBreakerInfo.ResumeLayout(false);
            tableLayoutBreakerInfo.PerformLayout();
            groupBoxCoefficients.ResumeLayout(false);
            groupBoxCoefficients.PerformLayout();
            tableLayoutCoefficients.ResumeLayout(false);
            tableLayoutCoefficients.PerformLayout();
            groupBoxDelay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)delayDataGridView).EndInit();
            groupBoxAlgorithm.ResumeLayout(false);
            groupBoxAlgorithm.PerformLayout();
            tableLayoutAlgorithm.ResumeLayout(false);
            tableLayoutAlgorithm.PerformLayout();
            groupBoxInstallation.ResumeLayout(false);
            groupBoxInstallation.PerformLayout();
            tableLayoutInstallation.ResumeLayout(false);
            tableLayoutInstallation.PerformLayout();
            groupBoxPrimaryCT.ResumeLayout(false);
            groupBoxPrimaryCT.PerformLayout();
            tableLayoutPrimaryCT.ResumeLayout(false);
            tableLayoutPrimaryCT.PerformLayout();
            groupBoxDebounce.ResumeLayout(false);
            groupBoxDebounce.PerformLayout();
            tableLayoutDebounce.ResumeLayout(false);
            tableLayoutDebounce.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxBreakerInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBreakerInfo;
        private System.Windows.Forms.Label labelNominalCurrent;
        private System.Windows.Forms.TextBox nominalCurrentTextBox;
        private System.Windows.Forms.Label labelSwitchType;
        private System.Windows.Forms.ComboBox switchTypeComboBox;
        private System.Windows.Forms.Label labelWarningThreshold;
        private System.Windows.Forms.TextBox warningThresholdTextBox;
        private System.Windows.Forms.Label labelAlarmThreshold;
        private System.Windows.Forms.TextBox alarmThresholdTextBox;
        private System.Windows.Forms.GroupBox groupBoxInstallation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutInstallation;
        private System.Windows.Forms.GroupBox groupBoxPrimaryCT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPrimaryCT;
        private System.Windows.Forms.TextBox secondaryCurrentTextBox;
        private System.Windows.Forms.Label labelPrimaryCurrent;
        private System.Windows.Forms.TextBox primaryCurrentTextBox;
        private System.Windows.Forms.Label labelSecondaryCurrent;
        private System.Windows.Forms.GroupBox groupBoxDebounce;
        private System.Windows.Forms.TableLayoutPanel tableLayoutDebounce;
        private System.Windows.Forms.TextBox debounceOnTextBox;
        private System.Windows.Forms.TextBox debounceOffTextBox;
        private System.Windows.Forms.Label labelDebounceOff;
        private System.Windows.Forms.Label labelDebounceOn;
        private System.Windows.Forms.GroupBox groupBoxAlgorithm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAlgorithm;
        private System.Windows.Forms.TextBox thresholdCurrentTextBox;
        private System.Windows.Forms.Label labelThresholdCurrent;
        private System.Windows.Forms.Label labelNominalOperations;
        private System.Windows.Forms.TextBox nominalOperationsTextBox;
        private System.Windows.Forms.GroupBox groupBoxCoefficients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCoefficients;
        private System.Windows.Forms.TextBox c1TextBox;
        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.TextBox c3TextBox;
        private System.Windows.Forms.TextBox c2TextBox;
        private System.Windows.Forms.Label labelC2;
        private System.Windows.Forms.Label labelC3;
        private System.Windows.Forms.Label labelC4;
        private System.Windows.Forms.GroupBox groupBoxDelay;
        private System.Windows.Forms.DataGridView delayDataGridView;
        private Label labelMaxCurrent;
        private TextBox maxCurrentTextBox;
        private TextBox switchModelTextBox;
        private Label labelInstallationPlace;
        private TextBox installationPlaceTextBox;
        private Label labelSwitchLabel;
        private TextBox switchLabelTextBox;
        private Label label1;
        public TextBox c4TextBox;
    }
}
