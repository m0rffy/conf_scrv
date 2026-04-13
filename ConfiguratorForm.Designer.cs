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
            rightPanel = new Panel();
            devicesPanel = new FlowLayoutPanel();
            devicesLabel = new Label();
            ChildFormPanel = new Panel();
            Sidebar.SuspendLayout();
            topPanel.SuspendLayout();
            menuStrip.SuspendLayout();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.Anchor = AnchorStyles.None;
            Sidebar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Sidebar.BackColor = Color.LightGray;
            Sidebar.BorderStyle = BorderStyle.FixedSingle;
            Sidebar.Controls.Add(btnManagement);
            Sidebar.Controls.Add(btnSettings);
            Sidebar.Controls.Add(btnGeneral);
            Sidebar.Controls.Add(btnNetwork);
            Sidebar.Controls.Add(btnJournal);
            Sidebar.FlowDirection = FlowDirection.TopDown;
            Sidebar.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Sidebar.Location = new Point(4, 54);
            Sidebar.Margin = new Padding(4);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(132, 838);
            Sidebar.TabIndex = 0;
            // 
            // btnManagement
            // 
            btnManagement.Anchor = AnchorStyles.Right;
            btnManagement.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnManagement.BackColor = Color.LightSkyBlue;
            btnManagement.FlatStyle = FlatStyle.Popup;
            btnManagement.Font = new Font("Times New Roman", 14.25F);
            btnManagement.Location = new Point(4, 4);
            btnManagement.Margin = new Padding(4);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(123, 35);
            btnManagement.TabIndex = 0;
            btnManagement.Text = "Управление";
            btnManagement.UseVisualStyleBackColor = false;
            btnManagement.Click += BtnManagement_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Right;
            btnSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSettings.BackColor = Color.LightSkyBlue;
            btnSettings.FlatStyle = FlatStyle.Popup;
            btnSettings.Font = new Font("Times New Roman", 14.25F);
            btnSettings.Location = new Point(4, 47);
            btnSettings.Margin = new Padding(4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(123, 35);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Настройки +";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += BtnSettings_Click;
            // 
            // btnGeneral
            // 
            btnGeneral.Anchor = AnchorStyles.Right;
            btnGeneral.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGeneral.BackColor = Color.LightSkyBlue;
            btnGeneral.FlatStyle = FlatStyle.Popup;
            btnGeneral.Font = new Font("Times New Roman", 14.25F);
            btnGeneral.Location = new Point(40, 90);
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
            btnNetwork.BackColor = Color.LightSkyBlue;
            btnNetwork.FlatStyle = FlatStyle.Popup;
            btnNetwork.Font = new Font("Times New Roman", 14.25F);
            btnNetwork.Location = new Point(40, 133);
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
            btnJournal.BackColor = Color.LightSkyBlue;
            btnJournal.FlatStyle = FlatStyle.Popup;
            btnJournal.Font = new Font("Times New Roman", 14.25F);
            btnJournal.Location = new Point(4, 176);
            btnJournal.Margin = new Padding(4);
            btnJournal.Name = "btnJournal";
            btnJournal.Size = new Size(123, 35);
            btnJournal.TabIndex = 4;
            btnJournal.Text = "Журнал";
            btnJournal.UseVisualStyleBackColor = false;
            btnJournal.Click += BtnJournal_Click;
            // 
            // topPanel
            // 
            topPanel.Anchor = AnchorStyles.None;
            topPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            topPanel.BackColor = Color.LightGray;
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(btnWrite);
            topPanel.Controls.Add(menuStrip);
            topPanel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            topPanel.Location = new Point(3, 2);
            topPanel.Margin = new Padding(4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1654, 48);
            topPanel.TabIndex = 2;
            // 
            // btnWrite
            // 
            btnWrite.Anchor = AnchorStyles.None;
            btnWrite.AutoSize = true;
            btnWrite.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnWrite.BackColor = Color.LightSkyBlue;
            btnWrite.FlatStyle = FlatStyle.Popup;
            btnWrite.Font = new Font("Times New Roman", 14.25F);
            btnWrite.ForeColor = Color.Black;
            btnWrite.Location = new Point(648, 8);
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
            menuStrip.BackColor = Color.LightGray;
            menuStrip.Dock = DockStyle.None;
            menuStrip.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip.GripStyle = ToolStripGripStyle.Visible;
            menuStrip.Items.AddRange(new ToolStripItem[] { helpMenu, UserHelp });
            menuStrip.Location = new Point(5, 6);
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
            // rightPanel
            // 
            rightPanel.Anchor = AnchorStyles.None;
            rightPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rightPanel.BackColor = Color.LightGray;
            rightPanel.BorderStyle = BorderStyle.FixedSingle;
            rightPanel.Controls.Add(devicesPanel);
            rightPanel.Controls.Add(devicesLabel);
            rightPanel.Location = new Point(1305, 55);
            rightPanel.Margin = new Padding(4);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(351, 836);
            rightPanel.TabIndex = 3;
            // 
            // devicesPanel
            // 
            devicesPanel.Anchor = AnchorStyles.None;
            devicesPanel.AutoScroll = true;
            devicesPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            devicesPanel.BackColor = Color.Gray;
            devicesPanel.BorderStyle = BorderStyle.FixedSingle;
            devicesPanel.FlowDirection = FlowDirection.TopDown;
            devicesPanel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            devicesPanel.Location = new Point(11, 66);
            devicesPanel.Margin = new Padding(4);
            devicesPanel.Name = "devicesPanel";
            devicesPanel.Size = new Size(330, 737);
            devicesPanel.TabIndex = 1;
            devicesPanel.WrapContents = false;
            // 
            // devicesLabel
            // 
            devicesLabel.Anchor = AnchorStyles.None;
            devicesLabel.AutoSize = true;
            devicesLabel.BackColor = Color.LightGray;
            devicesLabel.FlatStyle = FlatStyle.Flat;
            devicesLabel.Font = new Font("Times New Roman", 14.25F);
            devicesLabel.ForeColor = Color.Black;
            devicesLabel.Location = new Point(58, 20);
            devicesLabel.Margin = new Padding(4, 0, 4, 0);
            devicesLabel.Name = "devicesLabel";
            devicesLabel.Size = new Size(214, 21);
            devicesLabel.TabIndex = 0;
            devicesLabel.Text = "Сохранённые устройства";
            devicesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChildFormPanel
            // 
            ChildFormPanel.Anchor = AnchorStyles.None;
            ChildFormPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChildFormPanel.BackColor = Color.LightSteelBlue;
            ChildFormPanel.BorderStyle = BorderStyle.FixedSingle;
            ChildFormPanel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChildFormPanel.Location = new Point(138, 55);
            ChildFormPanel.Margin = new Padding(4);
            ChildFormPanel.Name = "ChildFormPanel";
            ChildFormPanel.Size = new Size(1164, 838);
            ChildFormPanel.TabIndex = 4;
            // 
            // ConfiguratorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1661, 896);
            Controls.Add(rightPanel);
            Controls.Add(ChildFormPanel);
            Controls.Add(Sidebar);
            Controls.Add(topPanel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(1725, 935);
            Name = "ConfiguratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Конфигуратор УЭТМ";
            Sidebar.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ResumeLayout(false);
        }
        public Panel ChildFormPanel;
        public Label devicesLabel;
        public MenuStrip menuStrip;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem UserHelp;
    }
}