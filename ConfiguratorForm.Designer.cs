namespace Uetm_2_0
{
    partial class ConfiguratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguratorForm));
            Sidebar = new FlowLayoutPanel();
            btnManagement = new Button();
            btnSettings = new Button();
            btnGeneral = new Button();
            btnNetwork = new Button();
            btnJournal = new Button();
            topPanel = new Panel();
            btnWrite = new Button();
            menuStrip = new MenuStrip();
            helpMenu = new ToolStripMenuItem();
            UserHelp = new ToolStripMenuItem();
            devicesLabel = new Label();
            devicesPanel = new FlowLayoutPanel();
            ChildFormPanel = new Panel();
            Sidebar.SuspendLayout();
            topPanel.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.Anchor = AnchorStyles.None;
            Sidebar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Sidebar.BackColor = Color.Silver;
            Sidebar.BorderStyle = BorderStyle.FixedSingle;
            Sidebar.Controls.Add(btnManagement);
            Sidebar.Controls.Add(btnSettings);
            Sidebar.Controls.Add(btnGeneral);
            Sidebar.Controls.Add(btnNetwork);
            Sidebar.Controls.Add(btnJournal);
            Sidebar.FlowDirection = FlowDirection.TopDown;
            Sidebar.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Sidebar.Location = new Point(5, 56);
            Sidebar.Margin = new Padding(4);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(142, 723);
            Sidebar.TabIndex = 0;
            // 
            // btnManagement
            // 
            btnManagement.Anchor = AnchorStyles.Right;
            btnManagement.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnManagement.BackColor = Color.LightSteelBlue;
            btnManagement.FlatStyle = FlatStyle.Popup;
            btnManagement.Font = new Font("Times New Roman", 14.25F);
            btnManagement.Location = new Point(4, 4);
            btnManagement.Margin = new Padding(4);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(132, 35);
            btnManagement.TabIndex = 0;
            btnManagement.Text = "Управление";
            btnManagement.UseVisualStyleBackColor = false;
            btnManagement.Click += BtnManagement_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Right;
            btnSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSettings.BackColor = Color.LightSteelBlue;
            btnSettings.FlatStyle = FlatStyle.Popup;
            btnSettings.Font = new Font("Times New Roman", 14.25F);
            btnSettings.Location = new Point(4, 47);
            btnSettings.Margin = new Padding(4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(132, 35);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Настройки +";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += BtnSettings_Click;
            // 
            // btnGeneral
            // 
            btnGeneral.Anchor = AnchorStyles.Right;
            btnGeneral.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGeneral.BackColor = Color.LightSteelBlue;
            btnGeneral.FlatStyle = FlatStyle.Popup;
            btnGeneral.Font = new Font("Times New Roman", 14.25F);
            btnGeneral.Location = new Point(49, 90);
            btnGeneral.Margin = new Padding(4);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(87, 35);
            btnGeneral.TabIndex = 2;
            btnGeneral.Text = "Общие";
            btnGeneral.UseVisualStyleBackColor = false;
            btnGeneral.Visible = false;
            btnGeneral.Click += BtnGeneral_Click;
            // 
            // btnNetwork
            // 
            btnNetwork.Anchor = AnchorStyles.Right;
            btnNetwork.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNetwork.BackColor = Color.LightSteelBlue;
            btnNetwork.FlatStyle = FlatStyle.Popup;
            btnNetwork.Font = new Font("Times New Roman", 14.25F);
            btnNetwork.Location = new Point(49, 133);
            btnNetwork.Margin = new Padding(4);
            btnNetwork.Name = "btnNetwork";
            btnNetwork.Size = new Size(87, 35);
            btnNetwork.TabIndex = 3;
            btnNetwork.Text = "Сетевые";
            btnNetwork.UseVisualStyleBackColor = false;
            btnNetwork.Visible = false;
            btnNetwork.Click += BtnNetwork_Click;
            // 
            // btnJournal
            // 
            btnJournal.Anchor = AnchorStyles.Right;
            btnJournal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnJournal.BackColor = Color.LightSteelBlue;
            btnJournal.FlatStyle = FlatStyle.Popup;
            btnJournal.Font = new Font("Times New Roman", 14.25F);
            btnJournal.Location = new Point(6, 176);
            btnJournal.Margin = new Padding(4);
            btnJournal.Name = "btnJournal";
            btnJournal.Size = new Size(130, 35);
            btnJournal.TabIndex = 4;
            btnJournal.Text = "Журнал";
            btnJournal.UseVisualStyleBackColor = false;
            btnJournal.Click += BtnJournal_Click;
            // 
            // topPanel
            // 
            topPanel.Anchor = AnchorStyles.None;
            topPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            topPanel.BackColor = Color.Silver;
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(btnWrite);
            topPanel.Controls.Add(menuStrip);
            topPanel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            topPanel.Location = new Point(5, 4);
            topPanel.Margin = new Padding(4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1465, 48);
            topPanel.TabIndex = 2;
            // 
            // btnWrite
            // 
            btnWrite.Anchor = AnchorStyles.None;
            btnWrite.AutoSize = true;
            btnWrite.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnWrite.BackColor = Color.LightSteelBlue;
            btnWrite.FlatStyle = FlatStyle.Popup;
            btnWrite.Font = new Font("Times New Roman", 14.25F);
            btnWrite.ForeColor = Color.Black;
            btnWrite.Location = new Point(626, 8);
            btnWrite.Margin = new Padding(4);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(92, 31);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Записать";
            btnWrite.UseVisualStyleBackColor = false;
            btnWrite.Click += BtnWrite_Click;
            // 
            // menuStrip
            // 
            menuStrip.Anchor = AnchorStyles.None;
            menuStrip.BackColor = Color.Transparent;
            menuStrip.Dock = DockStyle.None;
            menuStrip.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip.GripStyle = ToolStripGripStyle.Visible;
            menuStrip.Items.AddRange(new ToolStripItem[] { helpMenu, UserHelp });
            menuStrip.Location = new Point(6, 8);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(9, 3, 0, 3);
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(343, 31);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // helpMenu
            // 
            helpMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(89, 25);
            helpMenu.Text = "Справка";
            helpMenu.Click += helpMenu_Click;
            // 
            // UserHelp
            // 
            UserHelp.Name = "UserHelp";
            UserHelp.Size = new Size(236, 25);
            UserHelp.Text = "Руководство пользователя";
            UserHelp.Click += UserHelp_Click;
            // 
            // devicesLabel
            // 
            devicesLabel.Anchor = AnchorStyles.None;
            devicesLabel.AutoSize = true;
            devicesLabel.BackColor = Color.Transparent;
            devicesLabel.Font = new Font("Times New Roman", 14.25F);
            devicesLabel.ForeColor = Color.Black;
            devicesLabel.Location = new Point(1293, 59);
            devicesLabel.Margin = new Padding(4, 0, 4, 0);
            devicesLabel.Name = "devicesLabel";
            devicesLabel.Size = new Size(102, 21);
            devicesLabel.TabIndex = 0;
            devicesLabel.Text = "Устройства";
            devicesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // devicesPanel
            // 
            devicesPanel.Anchor = AnchorStyles.None;
            devicesPanel.AutoScroll = true;
            devicesPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            devicesPanel.BackColor = Color.Silver;
            devicesPanel.BorderStyle = BorderStyle.FixedSingle;
            devicesPanel.FlowDirection = FlowDirection.TopDown;
            devicesPanel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            devicesPanel.Location = new Point(1232, 86);
            devicesPanel.Margin = new Padding(4);
            devicesPanel.Name = "devicesPanel";
            devicesPanel.Size = new Size(238, 693);
            devicesPanel.TabIndex = 1;
            devicesPanel.WrapContents = false;
            // 
            // ChildFormPanel
            // 
            ChildFormPanel.Anchor = AnchorStyles.None;
            ChildFormPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChildFormPanel.BackColor = Color.LightSteelBlue;
            ChildFormPanel.BorderStyle = BorderStyle.FixedSingle;
            ChildFormPanel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChildFormPanel.Location = new Point(151, 56);
            ChildFormPanel.Margin = new Padding(4);
            ChildFormPanel.Name = "ChildFormPanel";
            ChildFormPanel.Size = new Size(1076, 723);
            ChildFormPanel.TabIndex = 4;
            // 
            // ConfiguratorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1474, 782);
            Controls.Add(devicesLabel);
            Controls.Add(devicesPanel);
            Controls.Add(ChildFormPanel);
            Controls.Add(Sidebar);
            Controls.Add(topPanel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ConfiguratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Конфигуратор УЭТМ";
            Sidebar.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        public Panel ChildFormPanel;
        public Label devicesLabel;
        public MenuStrip menuStrip;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem UserHelp;
    }
}