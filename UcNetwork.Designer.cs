namespace Uetm_2_0
{
    partial class UcNetwork
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
            tableLayoutPanelMain = new TableLayoutPanel();
            groupBoxEthernet = new GroupBox();
            tableLayoutEthernet = new TableLayoutPanel();
            macTextBox = new TextBox();
            labelIp = new Label();
            ipTextBox = new TextBox();
            labelMask = new Label();
            labelMac = new Label();
            maskTextBox = new TextBox();
            groupBoxPTP = new GroupBox();
            tableLayoutPTP = new TableLayoutPanel();
            labelPtpMasterMac = new Label();
            ptpMasterMacTextBox = new TextBox();
            labelPtpPort = new Label();
            ptpPortTextBox = new TextBox();
            labelPtpId = new Label();
            ptpIdTextBox = new TextBox();
            tableLayoutPanelMain.SuspendLayout();
            groupBoxEthernet.SuspendLayout();
            tableLayoutEthernet.SuspendLayout();
            groupBoxPTP.SuspendLayout();
            tableLayoutPTP.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.Anchor = AnchorStyles.None;
            tableLayoutPanelMain.AutoScroll = true;
            tableLayoutPanelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelMain.BackColor = Color.Transparent;
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.Controls.Add(groupBoxEthernet, 0, 0);
            tableLayoutPanelMain.Controls.Add(groupBoxPTP, 0, 1);
            tableLayoutPanelMain.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableLayoutPanelMain.ForeColor = Color.Black;
            tableLayoutPanelMain.Location = new Point(23, 21);
            tableLayoutPanelMain.Margin = new Padding(4);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(530, 354);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxEthernet
            // 
            groupBoxEthernet.Anchor = AnchorStyles.None;
            groupBoxEthernet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxEthernet.BackColor = Color.Transparent;
            groupBoxEthernet.Controls.Add(tableLayoutEthernet);
            groupBoxEthernet.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxEthernet.Location = new Point(56, 4);
            groupBoxEthernet.Margin = new Padding(4);
            groupBoxEthernet.Name = "groupBoxEthernet";
            groupBoxEthernet.Padding = new Padding(4);
            groupBoxEthernet.Size = new Size(417, 161);
            groupBoxEthernet.TabIndex = 0;
            groupBoxEthernet.TabStop = false;
            groupBoxEthernet.Text = "Ethernet";
            // 
            // tableLayoutEthernet
            // 
            tableLayoutEthernet.Anchor = AnchorStyles.None;
            tableLayoutEthernet.AutoSize = true;
            tableLayoutEthernet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutEthernet.ColumnCount = 2;
            tableLayoutEthernet.ColumnStyles.Add(new ColumnStyle());
            tableLayoutEthernet.ColumnStyles.Add(new ColumnStyle());
            tableLayoutEthernet.Controls.Add(macTextBox, 1, 0);
            tableLayoutEthernet.Controls.Add(labelIp, 0, 1);
            tableLayoutEthernet.Controls.Add(ipTextBox, 1, 1);
            tableLayoutEthernet.Controls.Add(labelMask, 0, 2);
            tableLayoutEthernet.Controls.Add(labelMac, 0, 0);
            tableLayoutEthernet.Controls.Add(maskTextBox, 1, 2);
            tableLayoutEthernet.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableLayoutEthernet.Location = new Point(48, 38);
            tableLayoutEthernet.Margin = new Padding(4);
            tableLayoutEthernet.Name = "tableLayoutEthernet";
            tableLayoutEthernet.RowCount = 3;
            tableLayoutEthernet.RowStyles.Add(new RowStyle());
            tableLayoutEthernet.RowStyles.Add(new RowStyle());
            tableLayoutEthernet.RowStyles.Add(new RowStyle());
            tableLayoutEthernet.Size = new Size(336, 102);
            tableLayoutEthernet.TabIndex = 0;
            // 
            // macTextBox
            // 
            macTextBox.Anchor = AnchorStyles.None;
            macTextBox.BorderStyle = BorderStyle.FixedSingle;
            macTextBox.Location = new Point(123, 4);
            macTextBox.Margin = new Padding(4);
            macTextBox.Name = "macTextBox";
            macTextBox.Size = new Size(208, 26);
            macTextBox.TabIndex = 1;
            macTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelIp
            // 
            labelIp.Anchor = AnchorStyles.Left;
            labelIp.AutoSize = true;
            labelIp.Location = new Point(4, 41);
            labelIp.Margin = new Padding(4, 0, 4, 0);
            labelIp.Name = "labelIp";
            labelIp.Size = new Size(63, 19);
            labelIp.TabIndex = 2;
            labelIp.Text = "IP адрес";
            // 
            // ipTextBox
            // 
            ipTextBox.Anchor = AnchorStyles.None;
            ipTextBox.BorderStyle = BorderStyle.FixedSingle;
            ipTextBox.Location = new Point(122, 38);
            ipTextBox.Margin = new Padding(4);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(209, 26);
            ipTextBox.TabIndex = 3;
            ipTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelMask
            // 
            labelMask.Anchor = AnchorStyles.Left;
            labelMask.AutoSize = true;
            labelMask.Location = new Point(4, 75);
            labelMask.Margin = new Padding(4, 0, 4, 0);
            labelMask.Name = "labelMask";
            labelMask.Size = new Size(110, 19);
            labelMask.TabIndex = 4;
            labelMask.Text = "Маска подсети";
            labelMask.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMac
            // 
            labelMac.Anchor = AnchorStyles.Left;
            labelMac.AutoSize = true;
            labelMac.Location = new Point(4, 7);
            labelMac.Margin = new Padding(4, 0, 4, 0);
            labelMac.Name = "labelMac";
            labelMac.Size = new Size(86, 19);
            labelMac.TabIndex = 0;
            labelMac.Text = "MAC адрес";
            // 
            // maskTextBox
            // 
            maskTextBox.Anchor = AnchorStyles.None;
            maskTextBox.BorderStyle = BorderStyle.FixedSingle;
            maskTextBox.Location = new Point(122, 72);
            maskTextBox.Margin = new Padding(4);
            maskTextBox.Name = "maskTextBox";
            maskTextBox.Size = new Size(210, 26);
            maskTextBox.TabIndex = 5;
            maskTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBoxPTP
            // 
            groupBoxPTP.Anchor = AnchorStyles.None;
            groupBoxPTP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxPTP.Controls.Add(tableLayoutPTP);
            groupBoxPTP.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxPTP.Location = new Point(52, 185);
            groupBoxPTP.Margin = new Padding(4);
            groupBoxPTP.Name = "groupBoxPTP";
            groupBoxPTP.Padding = new Padding(4);
            groupBoxPTP.Size = new Size(425, 153);
            groupBoxPTP.TabIndex = 2;
            groupBoxPTP.TabStop = false;
            groupBoxPTP.Text = "PTPv2";
            // 
            // tableLayoutPTP
            // 
            tableLayoutPTP.Anchor = AnchorStyles.None;
            tableLayoutPTP.AutoSize = true;
            tableLayoutPTP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPTP.ColumnCount = 2;
            tableLayoutPTP.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPTP.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPTP.Controls.Add(labelPtpMasterMac, 0, 0);
            tableLayoutPTP.Controls.Add(ptpMasterMacTextBox, 1, 0);
            tableLayoutPTP.Controls.Add(labelPtpPort, 0, 1);
            tableLayoutPTP.Controls.Add(ptpPortTextBox, 1, 1);
            tableLayoutPTP.Controls.Add(labelPtpId, 0, 2);
            tableLayoutPTP.Controls.Add(ptpIdTextBox, 1, 2);
            tableLayoutPTP.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableLayoutPTP.Location = new Point(33, 34);
            tableLayoutPTP.Margin = new Padding(4);
            tableLayoutPTP.Name = "tableLayoutPTP";
            tableLayoutPTP.RowCount = 3;
            tableLayoutPTP.RowStyles.Add(new RowStyle());
            tableLayoutPTP.RowStyles.Add(new RowStyle());
            tableLayoutPTP.RowStyles.Add(new RowStyle());
            tableLayoutPTP.Size = new Size(357, 102);
            tableLayoutPTP.TabIndex = 0;
            // 
            // labelPtpMasterMac
            // 
            labelPtpMasterMac.Anchor = AnchorStyles.Left;
            labelPtpMasterMac.AutoSize = true;
            labelPtpMasterMac.Location = new Point(4, 7);
            labelPtpMasterMac.Margin = new Padding(4, 0, 4, 0);
            labelPtpMasterMac.Name = "labelPtpMasterMac";
            labelPtpMasterMac.Size = new Size(137, 19);
            labelPtpMasterMac.TabIndex = 0;
            labelPtpMasterMac.Text = "MAC мастер часов";
            // 
            // ptpMasterMacTextBox
            // 
            ptpMasterMacTextBox.Anchor = AnchorStyles.None;
            ptpMasterMacTextBox.BorderStyle = BorderStyle.FixedSingle;
            ptpMasterMacTextBox.Location = new Point(150, 4);
            ptpMasterMacTextBox.Margin = new Padding(4);
            ptpMasterMacTextBox.Name = "ptpMasterMacTextBox";
            ptpMasterMacTextBox.Size = new Size(202, 26);
            ptpMasterMacTextBox.TabIndex = 1;
            ptpMasterMacTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPtpPort
            // 
            labelPtpPort.Anchor = AnchorStyles.Left;
            labelPtpPort.AutoSize = true;
            labelPtpPort.Location = new Point(4, 41);
            labelPtpPort.Margin = new Padding(4, 0, 4, 0);
            labelPtpPort.Name = "labelPtpPort";
            labelPtpPort.Size = new Size(43, 19);
            labelPtpPort.TabIndex = 2;
            labelPtpPort.Text = "Порт";
            labelPtpPort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ptpPortTextBox
            // 
            ptpPortTextBox.Anchor = AnchorStyles.None;
            ptpPortTextBox.BorderStyle = BorderStyle.FixedSingle;
            ptpPortTextBox.Location = new Point(150, 38);
            ptpPortTextBox.Margin = new Padding(4);
            ptpPortTextBox.Name = "ptpPortTextBox";
            ptpPortTextBox.Size = new Size(202, 26);
            ptpPortTextBox.TabIndex = 3;
            ptpPortTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPtpId
            // 
            labelPtpId.Anchor = AnchorStyles.Left;
            labelPtpId.AutoSize = true;
            labelPtpId.Location = new Point(4, 75);
            labelPtpId.Margin = new Padding(4, 0, 4, 0);
            labelPtpId.Name = "labelPtpId";
            labelPtpId.Size = new Size(115, 19);
            labelPtpId.TabIndex = 4;
            labelPtpId.Text = "Идентификатор";
            // 
            // ptpIdTextBox
            // 
            ptpIdTextBox.Anchor = AnchorStyles.None;
            ptpIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            ptpIdTextBox.Location = new Point(149, 72);
            ptpIdTextBox.Margin = new Padding(4);
            ptpIdTextBox.Name = "ptpIdTextBox";
            ptpIdTextBox.Size = new Size(204, 26);
            ptpIdTextBox.TabIndex = 5;
            ptpIdTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // UcNetwork
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            Controls.Add(tableLayoutPanelMain);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "UcNetwork";
            Size = new Size(574, 402);
            tableLayoutPanelMain.ResumeLayout(false);
            groupBoxEthernet.ResumeLayout(false);
            groupBoxEthernet.PerformLayout();
            tableLayoutEthernet.ResumeLayout(false);
            tableLayoutEthernet.PerformLayout();
            groupBoxPTP.ResumeLayout(false);
            groupBoxPTP.PerformLayout();
            tableLayoutPTP.ResumeLayout(false);
            tableLayoutPTP.PerformLayout();
            ResumeLayout(false);
        }
        private System.Windows.Forms.GroupBox groupBoxEthernet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutEthernet;
        private System.Windows.Forms.Label labelMac;
        private System.Windows.Forms.TextBox macTextBox;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label labelMask;
        private System.Windows.Forms.TextBox maskTextBox;
        public TableLayoutPanel tableLayoutPanelMain;
        public GroupBox groupBoxPTP;
        public TableLayoutPanel tableLayoutPTP;
        private Label labelPtpMasterMac;
        private TextBox ptpMasterMacTextBox;
        private Label labelPtpPort;
        private TextBox ptpPortTextBox;
        private Label labelPtpId;
        private TextBox ptpIdTextBox;
    }
}