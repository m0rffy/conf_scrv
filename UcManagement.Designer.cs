namespace Uetm_2_0
{
    partial class UcManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelAddDevice = new Panel();
            ipLabel = new Label();
            ipTextBox = new TextBox();
            addDeviceButton = new Button();
            portLabel = new Label();
            portTextBox = new TextBox();
            panelButtons = new Panel();
            SkyBlue = new Button();
            LightSteelBlue = new Button();
            rebootButton = new Button();
            groupBoxInfo = new GroupBox();
            tableLayoutInfo = new TableLayoutPanel();
            labelSerialNumber = new Label();
            serialNumberLabel = new Label();
            labelFirmwareVersion = new Label();
            firmwareVersionLabel = new Label();
            labelDeviceTime = new Label();
            deviceTimeLabel = new Label();
            groupBoxCNTV = new GroupBox();
            cntvDataGridView = new DataGridView();
            groupBoxStatus = new GroupBox();
            tableLayoutStatus = new TableLayoutPanel();
            labelDeviceStatus = new Label();
            deviceStatusLabel = new Label();
            labelSyncStatus = new Label();
            syncStatusLabel = new Label();
            labelRtcStatus = new Label();
            rtcStatusLabel = new Label();
            groupBoxRMS = new GroupBox();
            rmsDataGridView = new DataGridView();
            tableLayoutPanelMain.SuspendLayout();
            panelAddDevice.SuspendLayout();
            panelButtons.SuspendLayout();
            groupBoxInfo.SuspendLayout();
            tableLayoutInfo.SuspendLayout();
            groupBoxCNTV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cntvDataGridView).BeginInit();
            groupBoxStatus.SuspendLayout();
            tableLayoutStatus.SuspendLayout();
            groupBoxRMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rmsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.Anchor = AnchorStyles.None;
            tableLayoutPanelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelMain.BackColor = Color.Transparent;
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.Controls.Add(panelAddDevice, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 1);
            tableLayoutPanelMain.Controls.Add(groupBoxInfo, 0, 5);
            tableLayoutPanelMain.Controls.Add(groupBoxCNTV, 0, 2);
            tableLayoutPanelMain.Controls.Add(groupBoxStatus, 0, 4);
            tableLayoutPanelMain.Controls.Add(groupBoxRMS, 0, 3);
            tableLayoutPanelMain.Location = new Point(15, 6);
            tableLayoutPanelMain.Margin = new Padding(4);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 6;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(675, 644);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelAddDevice
            // 
            panelAddDevice.Anchor = AnchorStyles.None;
            panelAddDevice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelAddDevice.BackColor = Color.Transparent;
            panelAddDevice.Controls.Add(ipLabel);
            panelAddDevice.Controls.Add(ipTextBox);
            panelAddDevice.Controls.Add(addDeviceButton);
            panelAddDevice.Controls.Add(portLabel);
            panelAddDevice.Controls.Add(portTextBox);
            panelAddDevice.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelAddDevice.ForeColor = Color.Black;
            panelAddDevice.Location = new Point(79, 4);
            panelAddDevice.Margin = new Padding(4);
            panelAddDevice.Name = "panelAddDevice";
            panelAddDevice.Size = new Size(516, 41);
            panelAddDevice.TabIndex = 6;
            // 
            // ipLabel
            // 
            ipLabel.Anchor = AnchorStyles.None;
            ipLabel.AutoSize = true;
            ipLabel.Font = new Font("Times New Roman", 12F);
            ipLabel.Location = new Point(7, 10);
            ipLabel.Margin = new Padding(4, 0, 4, 0);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new Size(26, 19);
            ipLabel.TabIndex = 0;
            ipLabel.Text = "IP:";
            ipLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ipTextBox
            // 
            ipTextBox.Anchor = AnchorStyles.None;
            ipTextBox.BorderStyle = BorderStyle.FixedSingle;
            ipTextBox.Font = new Font("Times New Roman", 12F);
            ipTextBox.Location = new Point(40, 7);
            ipTextBox.Margin = new Padding(4);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(134, 26);
            ipTextBox.TabIndex = 1;
            ipTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // addDeviceButton
            // 
            addDeviceButton.Anchor = AnchorStyles.None;
            addDeviceButton.AutoSize = true;
            addDeviceButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addDeviceButton.BackColor = Color.SkyBlue;
            addDeviceButton.FlatStyle = FlatStyle.Flat;
            addDeviceButton.Font = new Font("Times New Roman", 12F);
            addDeviceButton.Location = new Point(337, 6);
            addDeviceButton.Margin = new Padding(4);
            addDeviceButton.Name = "addDeviceButton";
            addDeviceButton.Size = new Size(166, 31);
            addDeviceButton.TabIndex = 4;
            addDeviceButton.Text = "Добавить устройство";
            addDeviceButton.UseVisualStyleBackColor = false;
            addDeviceButton.Click += AddDeviceButton_Click;
            // 
            // portLabel
            // 
            portLabel.Anchor = AnchorStyles.None;
            portLabel.AutoSize = true;
            portLabel.Font = new Font("Times New Roman", 12F);
            portLabel.Location = new Point(197, 9);
            portLabel.Margin = new Padding(4, 0, 4, 0);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(46, 19);
            portLabel.TabIndex = 2;
            portLabel.Text = "Порт:";
            portLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // portTextBox
            // 
            portTextBox.Anchor = AnchorStyles.None;
            portTextBox.BorderStyle = BorderStyle.FixedSingle;
            portTextBox.Font = new Font("Times New Roman", 12F);
            portTextBox.Location = new Point(248, 6);
            portTextBox.Margin = new Padding(4);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(46, 26);
            portTextBox.TabIndex = 3;
            portTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panelButtons
            // 
            panelButtons.Anchor = AnchorStyles.None;
            panelButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelButtons.BackColor = Color.Transparent;
            panelButtons.Controls.Add(SkyBlue);
            panelButtons.Controls.Add(LightSteelBlue);
            panelButtons.Controls.Add(rebootButton);
            panelButtons.Font = new Font("Times New Roman", 12F);
            panelButtons.ForeColor = Color.Black;
            panelButtons.Location = new Point(36, 53);
            panelButtons.Margin = new Padding(4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(602, 42);
            panelButtons.TabIndex = 1;
            // 
            // SkyBlue
            // 
            SkyBlue.Anchor = AnchorStyles.None;
            SkyBlue.AutoSize = true;
            SkyBlue.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SkyBlue.BackColor = Color.SkyBlue;
            SkyBlue.FlatStyle = FlatStyle.Flat;
            SkyBlue.Font = new Font("Times New Roman", 12F);
            SkyBlue.Location = new Point(4, 6);
            SkyBlue.Margin = new Padding(4);
            SkyBlue.Name = "SkyBlue";
            SkyBlue.Size = new Size(228, 31);
            SkyBlue.TabIndex = 0;
            SkyBlue.Text = "Очистить значения по ресурсу";
            SkyBlue.UseVisualStyleBackColor = false;
            SkyBlue.Click += ClearResourceButton_Click;
            // 
            // LightSteelBlue
            // 
            LightSteelBlue.Anchor = AnchorStyles.None;
            LightSteelBlue.AutoSize = true;
            LightSteelBlue.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LightSteelBlue.BackColor = Color.SkyBlue;
            LightSteelBlue.FlatStyle = FlatStyle.Flat;
            LightSteelBlue.Font = new Font("Times New Roman", 12F);
            LightSteelBlue.Location = new Point(238, 6);
            LightSteelBlue.Margin = new Padding(4);
            LightSteelBlue.Name = "LightSteelBlue";
            LightSteelBlue.Size = new Size(155, 31);
            LightSteelBlue.TabIndex = 1;
            LightSteelBlue.Text = "Задать дату и время";
            LightSteelBlue.UseVisualStyleBackColor = false;
            LightSteelBlue.Click += SetTimeButton_Click;
            // 
            // rebootButton
            // 
            rebootButton.Anchor = AnchorStyles.None;
            rebootButton.AutoSize = true;
            rebootButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rebootButton.BackColor = Color.SkyBlue;
            rebootButton.FlatStyle = FlatStyle.Flat;
            rebootButton.Font = new Font("Times New Roman", 12F);
            rebootButton.Location = new Point(401, 6);
            rebootButton.Margin = new Padding(4);
            rebootButton.Name = "rebootButton";
            rebootButton.Size = new Size(197, 31);
            rebootButton.TabIndex = 2;
            rebootButton.Text = "Перезагрузить устройство";
            rebootButton.UseVisualStyleBackColor = false;
            rebootButton.Click += RebootButton_Click;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Anchor = AnchorStyles.None;
            groupBoxInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxInfo.Controls.Add(tableLayoutInfo);
            groupBoxInfo.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxInfo.ForeColor = Color.Black;
            groupBoxInfo.Location = new Point(33, 524);
            groupBoxInfo.Margin = new Padding(4);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Padding = new Padding(4);
            groupBoxInfo.Size = new Size(608, 114);
            groupBoxInfo.TabIndex = 5;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Информация об устройстве";
            // 
            // tableLayoutInfo
            // 
            tableLayoutInfo.Anchor = AnchorStyles.None;
            tableLayoutInfo.AutoSize = true;
            tableLayoutInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutInfo.ColumnCount = 2;
            tableLayoutInfo.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInfo.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInfo.Controls.Add(labelSerialNumber, 0, 0);
            tableLayoutInfo.Controls.Add(serialNumberLabel, 1, 0);
            tableLayoutInfo.Controls.Add(labelFirmwareVersion, 0, 1);
            tableLayoutInfo.Controls.Add(firmwareVersionLabel, 1, 1);
            tableLayoutInfo.Controls.Add(labelDeviceTime, 0, 2);
            tableLayoutInfo.Controls.Add(deviceTimeLabel, 1, 2);
            tableLayoutInfo.Font = new Font("Times New Roman", 12F);
            tableLayoutInfo.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutInfo.Location = new Point(190, 38);
            tableLayoutInfo.Margin = new Padding(4);
            tableLayoutInfo.Name = "tableLayoutInfo";
            tableLayoutInfo.RowCount = 3;
            tableLayoutInfo.RowStyles.Add(new RowStyle());
            tableLayoutInfo.RowStyles.Add(new RowStyle());
            tableLayoutInfo.RowStyles.Add(new RowStyle());
            tableLayoutInfo.Size = new Size(224, 57);
            tableLayoutInfo.TabIndex = 0;
            // 
            // labelSerialNumber
            // 
            labelSerialNumber.Anchor = AnchorStyles.None;
            labelSerialNumber.AutoSize = true;
            labelSerialNumber.Location = new Point(5, 0);
            labelSerialNumber.Margin = new Padding(4, 0, 4, 0);
            labelSerialNumber.Name = "labelSerialNumber";
            labelSerialNumber.Size = new Size(131, 19);
            labelSerialNumber.TabIndex = 0;
            labelSerialNumber.Text = "Серийный номер:";
            labelSerialNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // serialNumberLabel
            // 
            serialNumberLabel.Anchor = AnchorStyles.None;
            serialNumberLabel.AutoSize = true;
            serialNumberLabel.Location = new Point(145, 0);
            serialNumberLabel.Margin = new Padding(4, 0, 4, 0);
            serialNumberLabel.Name = "serialNumberLabel";
            serialNumberLabel.Size = new Size(75, 19);
            serialNumberLabel.TabIndex = 1;
            serialNumberLabel.Text = "Нет связи";
            serialNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFirmwareVersion
            // 
            labelFirmwareVersion.Anchor = AnchorStyles.None;
            labelFirmwareVersion.AutoSize = true;
            labelFirmwareVersion.Location = new Point(4, 19);
            labelFirmwareVersion.Margin = new Padding(4, 0, 4, 0);
            labelFirmwareVersion.Name = "labelFirmwareVersion";
            labelFirmwareVersion.Size = new Size(133, 19);
            labelFirmwareVersion.TabIndex = 2;
            labelFirmwareVersion.Text = "Версия прошивки:";
            labelFirmwareVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firmwareVersionLabel
            // 
            firmwareVersionLabel.Anchor = AnchorStyles.None;
            firmwareVersionLabel.AutoSize = true;
            firmwareVersionLabel.Location = new Point(145, 19);
            firmwareVersionLabel.Margin = new Padding(4, 0, 4, 0);
            firmwareVersionLabel.Name = "firmwareVersionLabel";
            firmwareVersionLabel.Size = new Size(75, 19);
            firmwareVersionLabel.TabIndex = 3;
            firmwareVersionLabel.Text = "Нет связи";
            firmwareVersionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDeviceTime
            // 
            labelDeviceTime.Anchor = AnchorStyles.None;
            labelDeviceTime.AutoSize = true;
            labelDeviceTime.Location = new Point(20, 38);
            labelDeviceTime.Margin = new Padding(4, 0, 4, 0);
            labelDeviceTime.Name = "labelDeviceTime";
            labelDeviceTime.Size = new Size(100, 19);
            labelDeviceTime.TabIndex = 4;
            labelDeviceTime.Text = "Время платы:";
            labelDeviceTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deviceTimeLabel
            // 
            deviceTimeLabel.Anchor = AnchorStyles.None;
            deviceTimeLabel.AutoSize = true;
            deviceTimeLabel.Location = new Point(145, 38);
            deviceTimeLabel.Margin = new Padding(4, 0, 4, 0);
            deviceTimeLabel.Name = "deviceTimeLabel";
            deviceTimeLabel.Size = new Size(75, 19);
            deviceTimeLabel.TabIndex = 5;
            deviceTimeLabel.Text = "Нет связи";
            deviceTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxCNTV
            // 
            groupBoxCNTV.Anchor = AnchorStyles.None;
            groupBoxCNTV.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxCNTV.Controls.Add(cntvDataGridView);
            groupBoxCNTV.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxCNTV.ForeColor = Color.Black;
            groupBoxCNTV.Location = new Point(40, 103);
            groupBoxCNTV.Margin = new Padding(4);
            groupBoxCNTV.Name = "groupBoxCNTV";
            groupBoxCNTV.Padding = new Padding(4);
            groupBoxCNTV.Size = new Size(594, 159);
            groupBoxCNTV.TabIndex = 3;
            groupBoxCNTV.TabStop = false;
            groupBoxCNTV.Text = "Значения по ресурсу";
            // 
            // cntvDataGridView
            // 
            cntvDataGridView.AllowUserToAddRows = false;
            cntvDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            cntvDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            cntvDataGridView.Anchor = AnchorStyles.None;
            cntvDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cntvDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cntvDataGridView.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            cntvDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            cntvDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            cntvDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            cntvDataGridView.EnableHeadersVisualStyles = false;
            cntvDataGridView.GridColor = Color.Gray;
            cntvDataGridView.Location = new Point(30, 25);
            cntvDataGridView.Margin = new Padding(4);
            cntvDataGridView.Name = "cntvDataGridView";
            cntvDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            cntvDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            cntvDataGridView.RowHeadersVisible = false;
            cntvDataGridView.RowHeadersWidth = 40;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            cntvDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            cntvDataGridView.ScrollBars = ScrollBars.None;
            cntvDataGridView.Size = new Size(535, 123);
            cntvDataGridView.TabIndex = 0;
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Anchor = AnchorStyles.None;
            groupBoxStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxStatus.Controls.Add(tableLayoutStatus);
            groupBoxStatus.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxStatus.ForeColor = Color.Black;
            groupBoxStatus.Location = new Point(34, 421);
            groupBoxStatus.Margin = new Padding(4);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Padding = new Padding(4);
            groupBoxStatus.Size = new Size(607, 94);
            groupBoxStatus.TabIndex = 4;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Статус устройства";
            // 
            // tableLayoutStatus
            // 
            tableLayoutStatus.Anchor = AnchorStyles.None;
            tableLayoutStatus.AutoSize = true;
            tableLayoutStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutStatus.BackColor = Color.Transparent;
            tableLayoutStatus.ColumnCount = 2;
            tableLayoutStatus.ColumnStyles.Add(new ColumnStyle());
            tableLayoutStatus.ColumnStyles.Add(new ColumnStyle());
            tableLayoutStatus.Controls.Add(labelDeviceStatus, 0, 0);
            tableLayoutStatus.Controls.Add(deviceStatusLabel, 1, 0);
            tableLayoutStatus.Controls.Add(labelSyncStatus, 0, 1);
            tableLayoutStatus.Controls.Add(syncStatusLabel, 1, 1);
            tableLayoutStatus.Controls.Add(labelRtcStatus, 0, 2);
            tableLayoutStatus.Controls.Add(rtcStatusLabel, 1, 2);
            tableLayoutStatus.Font = new Font("Times New Roman", 12F);
            tableLayoutStatus.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutStatus.Location = new Point(178, 25);
            tableLayoutStatus.Margin = new Padding(4);
            tableLayoutStatus.Name = "tableLayoutStatus";
            tableLayoutStatus.RowCount = 3;
            tableLayoutStatus.RowStyles.Add(new RowStyle());
            tableLayoutStatus.RowStyles.Add(new RowStyle());
            tableLayoutStatus.RowStyles.Add(new RowStyle());
            tableLayoutStatus.Size = new Size(257, 57);
            tableLayoutStatus.TabIndex = 0;
            // 
            // labelDeviceStatus
            // 
            labelDeviceStatus.Anchor = AnchorStyles.None;
            labelDeviceStatus.AutoSize = true;
            labelDeviceStatus.BackColor = Color.Transparent;
            labelDeviceStatus.Location = new Point(11, 0);
            labelDeviceStatus.Margin = new Padding(4, 0, 4, 0);
            labelDeviceStatus.Name = "labelDeviceStatus";
            labelDeviceStatus.Size = new Size(151, 19);
            labelDeviceStatus.TabIndex = 0;
            labelDeviceStatus.Text = "Устройство в работе:";
            labelDeviceStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deviceStatusLabel
            // 
            deviceStatusLabel.Anchor = AnchorStyles.None;
            deviceStatusLabel.AutoSize = true;
            deviceStatusLabel.Location = new Point(178, 0);
            deviceStatusLabel.Margin = new Padding(4, 0, 4, 0);
            deviceStatusLabel.Name = "deviceStatusLabel";
            deviceStatusLabel.Size = new Size(75, 19);
            deviceStatusLabel.TabIndex = 1;
            deviceStatusLabel.Text = "Нет связи";
            deviceStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSyncStatus
            // 
            labelSyncStatus.Anchor = AnchorStyles.None;
            labelSyncStatus.AutoSize = true;
            labelSyncStatus.Location = new Point(4, 19);
            labelSyncStatus.Margin = new Padding(4, 0, 4, 0);
            labelSyncStatus.Name = "labelSyncStatus";
            labelSyncStatus.Size = new Size(166, 19);
            labelSyncStatus.TabIndex = 2;
            labelSyncStatus.Text = "Синхронизация PTPv2:";
            labelSyncStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // syncStatusLabel
            // 
            syncStatusLabel.Anchor = AnchorStyles.None;
            syncStatusLabel.AutoSize = true;
            syncStatusLabel.Location = new Point(178, 19);
            syncStatusLabel.Margin = new Padding(4, 0, 4, 0);
            syncStatusLabel.Name = "syncStatusLabel";
            syncStatusLabel.Size = new Size(75, 19);
            syncStatusLabel.TabIndex = 3;
            syncStatusLabel.Text = "Нет связи";
            syncStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRtcStatus
            // 
            labelRtcStatus.Anchor = AnchorStyles.None;
            labelRtcStatus.AutoSize = true;
            labelRtcStatus.Location = new Point(21, 38);
            labelRtcStatus.Margin = new Padding(4, 0, 4, 0);
            labelRtcStatus.Name = "labelRtcStatus";
            labelRtcStatus.Size = new Size(131, 19);
            labelRtcStatus.TabIndex = 4;
            labelRtcStatus.Text = "Внутренние часы:";
            labelRtcStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtcStatusLabel
            // 
            rtcStatusLabel.Anchor = AnchorStyles.None;
            rtcStatusLabel.AutoSize = true;
            rtcStatusLabel.Location = new Point(178, 38);
            rtcStatusLabel.Margin = new Padding(4, 0, 4, 0);
            rtcStatusLabel.Name = "rtcStatusLabel";
            rtcStatusLabel.Size = new Size(75, 19);
            rtcStatusLabel.TabIndex = 5;
            rtcStatusLabel.Text = "Нет связи";
            rtcStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxRMS
            // 
            groupBoxRMS.Anchor = AnchorStyles.None;
            groupBoxRMS.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxRMS.BackColor = Color.Transparent;
            groupBoxRMS.Controls.Add(rmsDataGridView);
            groupBoxRMS.FlatStyle = FlatStyle.Flat;
            groupBoxRMS.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxRMS.ForeColor = Color.Black;
            groupBoxRMS.Location = new Point(35, 270);
            groupBoxRMS.Margin = new Padding(4);
            groupBoxRMS.Name = "groupBoxRMS";
            groupBoxRMS.Padding = new Padding(4);
            groupBoxRMS.Size = new Size(604, 143);
            groupBoxRMS.TabIndex = 2;
            groupBoxRMS.TabStop = false;
            groupBoxRMS.Text = "Действующее значение тока (А)";
            // 
            // rmsDataGridView
            // 
            rmsDataGridView.AllowUserToAddRows = false;
            rmsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Gainsboro;
            rmsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            rmsDataGridView.Anchor = AnchorStyles.None;
            rmsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rmsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rmsDataGridView.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Gainsboro;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            rmsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            rmsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.Gainsboro;
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            rmsDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            rmsDataGridView.EnableHeadersVisualStyles = false;
            rmsDataGridView.GridColor = Color.Gray;
            rmsDataGridView.Location = new Point(35, 27);
            rmsDataGridView.Margin = new Padding(4);
            rmsDataGridView.Name = "rmsDataGridView";
            rmsDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.Gainsboro;
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            rmsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            rmsDataGridView.RowHeadersVisible = false;
            rmsDataGridView.RowHeadersWidth = 40;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.Gainsboro;
            rmsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            rmsDataGridView.ScrollBars = ScrollBars.None;
            rmsDataGridView.Size = new Size(535, 103);
            rmsDataGridView.TabIndex = 0;
            // 
            // UcManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            Controls.Add(tableLayoutPanelMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "UcManagement";
            Size = new Size(704, 665);
            tableLayoutPanelMain.ResumeLayout(false);
            panelAddDevice.ResumeLayout(false);
            panelAddDevice.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            tableLayoutInfo.ResumeLayout(false);
            tableLayoutInfo.PerformLayout();
            groupBoxCNTV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cntvDataGridView).EndInit();
            groupBoxStatus.ResumeLayout(false);
            groupBoxStatus.PerformLayout();
            tableLayoutStatus.ResumeLayout(false);
            tableLayoutStatus.PerformLayout();
            groupBoxRMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rmsDataGridView).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        public Panel panelAddDevice;
        private Label ipLabel;
        private TextBox ipTextBox;
        private Button addDeviceButton;
        private Label portLabel;
        private TextBox portTextBox;
        public Panel panelButtons;
        private Button SkyBlue;
        private Button LightSteelBlue;
        private Button rebootButton;
        public GroupBox groupBoxInfo;
        private TableLayoutPanel tableLayoutInfo;
        private Label labelSerialNumber;
        private Label serialNumberLabel;
        private Label labelFirmwareVersion;
        private Label firmwareVersionLabel;
        private Label labelDeviceTime;
        private Label deviceTimeLabel;
        public GroupBox groupBoxCNTV;
        public DataGridView cntvDataGridView;
        public GroupBox groupBoxStatus;
        private TableLayoutPanel tableLayoutStatus;
        private Label labelDeviceStatus;
        private Label deviceStatusLabel;
        private Label labelSyncStatus;
        private Label syncStatusLabel;
        private Label labelRtcStatus;
        private Label rtcStatusLabel;
        public GroupBox groupBoxRMS;
        public DataGridView rmsDataGridView;
    }
}
