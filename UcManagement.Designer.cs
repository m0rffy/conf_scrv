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
            tableLayoutPanelMain = new TableLayoutPanel();
            panelAddDevice = new Panel();
            ipLabel = new Label();
            ipTextBox = new TextBox();
            addDeviceButton = new Button();
            portLabel = new Label();
            portTextBox = new TextBox();
            panelButtons = new Panel();
            clearResourceButton = new Button();
            setTimeButton = new Button();
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
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.Controls.Add(panelAddDevice, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 1);
            tableLayoutPanelMain.Controls.Add(groupBoxInfo, 0, 6);
            tableLayoutPanelMain.Controls.Add(groupBoxCNTV, 0, 3);
            tableLayoutPanelMain.Controls.Add(groupBoxStatus, 0, 5);
            tableLayoutPanelMain.Controls.Add(groupBoxRMS, 0, 4);
            tableLayoutPanelMain.Location = new Point(15, 19);
            tableLayoutPanelMain.Margin = new Padding(4);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 7;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 178F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 153F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 118F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanelMain.Size = new Size(750, 675);
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
            panelAddDevice.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelAddDevice.Location = new Point(69, 4);
            panelAddDevice.Margin = new Padding(4);
            panelAddDevice.Name = "panelAddDevice";
            panelAddDevice.Size = new Size(612, 42);
            panelAddDevice.TabIndex = 6;
            // 
            // ipLabel
            // 
            ipLabel.Anchor = AnchorStyles.None;
            ipLabel.AutoSize = true;
            ipLabel.Font = new Font("Times New Roman", 12F);
            ipLabel.Location = new Point(45, 11);
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
            ipTextBox.Location = new Point(79, 8);
            ipTextBox.Margin = new Padding(4);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(123, 26);
            ipTextBox.TabIndex = 1;
            ipTextBox.Text = "192.168.137.";
            // 
            // addDeviceButton
            // 
            addDeviceButton.Anchor = AnchorStyles.None;
            addDeviceButton.AutoSize = true;
            addDeviceButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addDeviceButton.BackColor = Color.LightSkyBlue;
            addDeviceButton.FlatStyle = FlatStyle.Popup;
            addDeviceButton.Font = new Font("Times New Roman", 12F);
            addDeviceButton.Location = new Point(422, 7);
            addDeviceButton.Margin = new Padding(4);
            addDeviceButton.Name = "addDeviceButton";
            addDeviceButton.Size = new Size(164, 29);
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
            portLabel.Location = new Point(270, 10);
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
            portTextBox.Location = new Point(324, 8);
            portTextBox.Margin = new Padding(4);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(36, 26);
            portTextBox.TabIndex = 3;
            portTextBox.Text = "502";
            // 
            // panelButtons
            // 
            panelButtons.Anchor = AnchorStyles.None;
            panelButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelButtons.BackColor = Color.Transparent;
            panelButtons.Controls.Add(clearResourceButton);
            panelButtons.Controls.Add(setTimeButton);
            panelButtons.Controls.Add(rebootButton);
            panelButtons.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelButtons.ForeColor = Color.Black;
            panelButtons.Location = new Point(67, 54);
            panelButtons.Margin = new Padding(4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(615, 50);
            panelButtons.TabIndex = 1;
            // 
            // clearResourceButton
            // 
            clearResourceButton.Anchor = AnchorStyles.None;
            clearResourceButton.AutoSize = true;
            clearResourceButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clearResourceButton.BackColor = Color.LightSkyBlue;
            clearResourceButton.FlatStyle = FlatStyle.Popup;
            clearResourceButton.Font = new Font("Times New Roman", 12F);
            clearResourceButton.Location = new Point(11, 10);
            clearResourceButton.Margin = new Padding(4);
            clearResourceButton.Name = "clearResourceButton";
            clearResourceButton.Size = new Size(226, 29);
            clearResourceButton.TabIndex = 0;
            clearResourceButton.Text = "Очистить значения по ресурсу";
            clearResourceButton.UseVisualStyleBackColor = false;
            clearResourceButton.Click += ClearResourceButton_Click;
            // 
            // setTimeButton
            // 
            setTimeButton.Anchor = AnchorStyles.None;
            setTimeButton.AutoSize = true;
            setTimeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            setTimeButton.BackColor = Color.LightSkyBlue;
            setTimeButton.FlatStyle = FlatStyle.Popup;
            setTimeButton.Font = new Font("Times New Roman", 12F);
            setTimeButton.Location = new Point(247, 10);
            setTimeButton.Margin = new Padding(4);
            setTimeButton.Name = "setTimeButton";
            setTimeButton.Size = new Size(153, 29);
            setTimeButton.TabIndex = 1;
            setTimeButton.Text = "Задать дату и время";
            setTimeButton.UseVisualStyleBackColor = false;
            setTimeButton.Click += SetTimeButton_Click;
            // 
            // rebootButton
            // 
            rebootButton.Anchor = AnchorStyles.None;
            rebootButton.AutoSize = true;
            rebootButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rebootButton.BackColor = Color.LightSkyBlue;
            rebootButton.FlatStyle = FlatStyle.Popup;
            rebootButton.Font = new Font("Times New Roman", 12F);
            rebootButton.Location = new Point(411, 10);
            rebootButton.Margin = new Padding(4);
            rebootButton.Name = "rebootButton";
            rebootButton.Size = new Size(195, 29);
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
            groupBoxInfo.Location = new Point(74, 563);
            groupBoxInfo.Margin = new Padding(4);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Padding = new Padding(4);
            groupBoxInfo.Size = new Size(601, 106);
            groupBoxInfo.TabIndex = 5;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Информация об устройстве";
            // 
            // tableLayoutInfo
            // 
            tableLayoutInfo.Anchor = AnchorStyles.None;
            tableLayoutInfo.AutoScroll = true;
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
            tableLayoutInfo.Location = new Point(128, 33);
            tableLayoutInfo.Margin = new Padding(4);
            tableLayoutInfo.Name = "tableLayoutInfo";
            tableLayoutInfo.RowCount = 3;
            tableLayoutInfo.RowStyles.Add(new RowStyle());
            tableLayoutInfo.RowStyles.Add(new RowStyle());
            tableLayoutInfo.RowStyles.Add(new RowStyle());
            tableLayoutInfo.Size = new Size(380, 57);
            tableLayoutInfo.TabIndex = 0;
            // 
            // labelSerialNumber
            // 
            labelSerialNumber.Anchor = AnchorStyles.Left;
            labelSerialNumber.AutoSize = true;
            labelSerialNumber.Location = new Point(4, 0);
            labelSerialNumber.Margin = new Padding(4, 0, 4, 0);
            labelSerialNumber.Name = "labelSerialNumber";
            labelSerialNumber.Size = new Size(131, 19);
            labelSerialNumber.TabIndex = 0;
            labelSerialNumber.Text = "Серийный номер:";
            // 
            // serialNumberLabel
            // 
            serialNumberLabel.Anchor = AnchorStyles.Left;
            serialNumberLabel.AutoSize = true;
            serialNumberLabel.Location = new Point(145, 0);
            serialNumberLabel.Margin = new Padding(4, 0, 4, 0);
            serialNumberLabel.Name = "serialNumberLabel";
            serialNumberLabel.Size = new Size(75, 19);
            serialNumberLabel.TabIndex = 1;
            serialNumberLabel.Text = "Нет связи";
            // 
            // labelFirmwareVersion
            // 
            labelFirmwareVersion.Anchor = AnchorStyles.Left;
            labelFirmwareVersion.AutoSize = true;
            labelFirmwareVersion.Location = new Point(4, 19);
            labelFirmwareVersion.Margin = new Padding(4, 0, 4, 0);
            labelFirmwareVersion.Name = "labelFirmwareVersion";
            labelFirmwareVersion.Size = new Size(133, 19);
            labelFirmwareVersion.TabIndex = 2;
            labelFirmwareVersion.Text = "Версия прошивки:";
            // 
            // firmwareVersionLabel
            // 
            firmwareVersionLabel.Anchor = AnchorStyles.Left;
            firmwareVersionLabel.AutoSize = true;
            firmwareVersionLabel.Location = new Point(145, 19);
            firmwareVersionLabel.Margin = new Padding(4, 0, 4, 0);
            firmwareVersionLabel.Name = "firmwareVersionLabel";
            firmwareVersionLabel.Size = new Size(75, 19);
            firmwareVersionLabel.TabIndex = 3;
            firmwareVersionLabel.Text = "Нет связи";
            // 
            // labelDeviceTime
            // 
            labelDeviceTime.Anchor = AnchorStyles.Left;
            labelDeviceTime.AutoSize = true;
            labelDeviceTime.Location = new Point(4, 38);
            labelDeviceTime.Margin = new Padding(4, 0, 4, 0);
            labelDeviceTime.Name = "labelDeviceTime";
            labelDeviceTime.Size = new Size(100, 19);
            labelDeviceTime.TabIndex = 4;
            labelDeviceTime.Text = "Время платы:";
            // 
            // deviceTimeLabel
            // 
            deviceTimeLabel.Anchor = AnchorStyles.Left;
            deviceTimeLabel.AutoSize = true;
            deviceTimeLabel.Location = new Point(145, 38);
            deviceTimeLabel.Margin = new Padding(4, 0, 4, 0);
            deviceTimeLabel.Name = "deviceTimeLabel";
            deviceTimeLabel.Size = new Size(75, 19);
            deviceTimeLabel.TabIndex = 5;
            deviceTimeLabel.Text = "Нет связи";
            // 
            // groupBoxCNTV
            // 
            groupBoxCNTV.Anchor = AnchorStyles.None;
            groupBoxCNTV.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxCNTV.Controls.Add(cntvDataGridView);
            groupBoxCNTV.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxCNTV.Location = new Point(72, 112);
            groupBoxCNTV.Margin = new Padding(4);
            groupBoxCNTV.Name = "groupBoxCNTV";
            groupBoxCNTV.Padding = new Padding(4);
            groupBoxCNTV.Size = new Size(606, 170);
            groupBoxCNTV.TabIndex = 3;
            groupBoxCNTV.TabStop = false;
            groupBoxCNTV.Text = "Значения по ресурсу";
            // 
            // cntvDataGridView
            // 
            cntvDataGridView.AllowUserToAddRows = false;
            cntvDataGridView.AllowUserToDeleteRows = false;
            cntvDataGridView.Anchor = AnchorStyles.None;
            cntvDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cntvDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cntvDataGridView.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            cntvDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            cntvDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            cntvDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            cntvDataGridView.GridColor = Color.LightGray;
            cntvDataGridView.Location = new Point(17, 28);
            cntvDataGridView.Margin = new Padding(4);
            cntvDataGridView.Name = "cntvDataGridView";
            cntvDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            cntvDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            cntvDataGridView.RowHeadersVisible = false;
            cntvDataGridView.ScrollBars = ScrollBars.None;
            cntvDataGridView.Size = new Size(578, 127);
            cntvDataGridView.TabIndex = 0;
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Anchor = AnchorStyles.None;
            groupBoxStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxStatus.Controls.Add(tableLayoutStatus);
            groupBoxStatus.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxStatus.Location = new Point(75, 443);
            groupBoxStatus.Margin = new Padding(4);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Padding = new Padding(4);
            groupBoxStatus.Size = new Size(599, 110);
            groupBoxStatus.TabIndex = 4;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Статус устройства";
            // 
            // tableLayoutStatus
            // 
            tableLayoutStatus.Anchor = AnchorStyles.None;
            tableLayoutStatus.AutoScroll = true;
            tableLayoutStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            tableLayoutStatus.Location = new Point(129, 30);
            tableLayoutStatus.Margin = new Padding(4);
            tableLayoutStatus.Name = "tableLayoutStatus";
            tableLayoutStatus.RowCount = 3;
            tableLayoutStatus.RowStyles.Add(new RowStyle());
            tableLayoutStatus.RowStyles.Add(new RowStyle());
            tableLayoutStatus.RowStyles.Add(new RowStyle());
            tableLayoutStatus.Size = new Size(379, 60);
            tableLayoutStatus.TabIndex = 0;
            // 
            // labelDeviceStatus
            // 
            labelDeviceStatus.Anchor = AnchorStyles.Left;
            labelDeviceStatus.AutoSize = true;
            labelDeviceStatus.Location = new Point(4, 0);
            labelDeviceStatus.Margin = new Padding(4, 0, 4, 0);
            labelDeviceStatus.Name = "labelDeviceStatus";
            labelDeviceStatus.Size = new Size(151, 19);
            labelDeviceStatus.TabIndex = 0;
            labelDeviceStatus.Text = "Устройство в работе:";
            labelDeviceStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deviceStatusLabel
            // 
            deviceStatusLabel.Anchor = AnchorStyles.Left;
            deviceStatusLabel.AutoSize = true;
            deviceStatusLabel.Location = new Point(178, 0);
            deviceStatusLabel.Margin = new Padding(4, 0, 4, 0);
            deviceStatusLabel.Name = "deviceStatusLabel";
            deviceStatusLabel.Size = new Size(75, 19);
            deviceStatusLabel.TabIndex = 1;
            deviceStatusLabel.Text = "Нет связи";
            // 
            // labelSyncStatus
            // 
            labelSyncStatus.Anchor = AnchorStyles.Left;
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
            syncStatusLabel.Anchor = AnchorStyles.Left;
            syncStatusLabel.AutoSize = true;
            syncStatusLabel.Location = new Point(178, 19);
            syncStatusLabel.Margin = new Padding(4, 0, 4, 0);
            syncStatusLabel.Name = "syncStatusLabel";
            syncStatusLabel.Size = new Size(75, 19);
            syncStatusLabel.TabIndex = 3;
            syncStatusLabel.Text = "Нет связи";
            // 
            // labelRtcStatus
            // 
            labelRtcStatus.Anchor = AnchorStyles.Left;
            labelRtcStatus.AutoSize = true;
            labelRtcStatus.Location = new Point(4, 39);
            labelRtcStatus.Margin = new Padding(4, 0, 4, 0);
            labelRtcStatus.Name = "labelRtcStatus";
            labelRtcStatus.Size = new Size(131, 19);
            labelRtcStatus.TabIndex = 4;
            labelRtcStatus.Text = "Внутренние часы:";
            labelRtcStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtcStatusLabel
            // 
            rtcStatusLabel.Anchor = AnchorStyles.Left;
            rtcStatusLabel.AutoSize = true;
            rtcStatusLabel.Location = new Point(178, 39);
            rtcStatusLabel.Margin = new Padding(4, 0, 4, 0);
            rtcStatusLabel.Name = "rtcStatusLabel";
            rtcStatusLabel.Size = new Size(75, 19);
            rtcStatusLabel.TabIndex = 5;
            rtcStatusLabel.Text = "Нет связи";
            // 
            // groupBoxRMS
            // 
            groupBoxRMS.Anchor = AnchorStyles.None;
            groupBoxRMS.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxRMS.BackColor = Color.Transparent;
            groupBoxRMS.Controls.Add(rmsDataGridView);
            groupBoxRMS.FlatStyle = FlatStyle.Flat;
            groupBoxRMS.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxRMS.Location = new Point(79, 293);
            groupBoxRMS.Margin = new Padding(4);
            groupBoxRMS.Name = "groupBoxRMS";
            groupBoxRMS.Padding = new Padding(4);
            groupBoxRMS.Size = new Size(592, 139);
            groupBoxRMS.TabIndex = 2;
            groupBoxRMS.TabStop = false;
            groupBoxRMS.Text = "Действующее значение тока, А";
            // 
            // rmsDataGridView
            // 
            rmsDataGridView.AllowUserToAddRows = false;
            rmsDataGridView.AllowUserToDeleteRows = false;
            rmsDataGridView.Anchor = AnchorStyles.None;
            rmsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rmsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rmsDataGridView.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            rmsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            rmsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            rmsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            rmsDataGridView.GridColor = Color.LightGray;
            rmsDataGridView.Location = new Point(106, 27);
            rmsDataGridView.Margin = new Padding(4);
            rmsDataGridView.Name = "rmsDataGridView";
            rmsDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            rmsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            rmsDataGridView.RowHeadersVisible = false;
            rmsDataGridView.ScrollBars = ScrollBars.None;
            rmsDataGridView.Size = new Size(380, 105);
            rmsDataGridView.TabIndex = 0;
            // 
            // UcManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanelMain);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "UcManagement";
            Size = new Size(780, 711);
            tableLayoutPanelMain.ResumeLayout(false);
            panelAddDevice.ResumeLayout(false);
            panelAddDevice.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            groupBoxInfo.ResumeLayout(false);
            tableLayoutInfo.ResumeLayout(false);
            tableLayoutInfo.PerformLayout();
            groupBoxCNTV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cntvDataGridView).EndInit();
            groupBoxStatus.ResumeLayout(false);
            tableLayoutStatus.ResumeLayout(false);
            tableLayoutStatus.PerformLayout();
            groupBoxRMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rmsDataGridView).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button addDeviceButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutStatus;
        private System.Windows.Forms.Label labelDeviceStatus;
        private System.Windows.Forms.Label deviceStatusLabel;
        private System.Windows.Forms.Label labelSyncStatus;
        private System.Windows.Forms.Label syncStatusLabel;
        private System.Windows.Forms.Label labelRtcStatus;
        private System.Windows.Forms.Label rtcStatusLabel;
        public Panel panelButtons;
        private Button clearResourceButton;
        private Button setTimeButton;
        private Button rebootButton;
        private TableLayoutPanel tableLayoutInfo;
        private Label labelSerialNumber;
        private Label serialNumberLabel;
        private Label labelFirmwareVersion;
        private Label firmwareVersionLabel;
        private Label labelDeviceTime;
        private Label deviceTimeLabel;
        public GroupBox groupBoxRMS;
        public GroupBox groupBoxStatus;
        public GroupBox groupBoxInfo;
        public GroupBox groupBoxCNTV;
        public DataGridView rmsDataGridView;
        public DataGridView cntvDataGridView;
        public Panel panelAddDevice;
    }
}
