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

        private FlowLayoutPanel Sidebar;
        private RoundedButton btnManagement;
        private RoundedButton btnSettings;
        private RoundedButton btnGeneral;
        private RoundedButton btnNetwork;
        private RoundedButton btnJournal;
        private Panel topPanel;
        private RoundedButton btnWrite;
        private TableLayoutPanel devicesPanel;


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguratorForm));
            Sidebar = new FlowLayoutPanel();
            btnManagement = new RoundedButton();
            btnSettings = new RoundedButton();
            btnGeneral = new RoundedButton();
            btnNetwork = new RoundedButton();
            btnJournal = new RoundedButton();
            topPanel = new Panel();
            menuStrip = new MenuStrip();
            helpMenu = new ToolStripMenuItem();
            UserHelp = new ToolStripMenuItem();
            btnChangePassword = new RoundedButton();
            devicesLabel = new Label();
            btnWrite = new RoundedButton();
            devicesPanel = new TableLayoutPanel();
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
            Sidebar.BackColor = Color.LightGray;
            Sidebar.BorderStyle = BorderStyle.FixedSingle;
            Sidebar.Controls.Add(btnManagement);
            Sidebar.Controls.Add(btnSettings);
            Sidebar.Controls.Add(btnGeneral);
            Sidebar.Controls.Add(btnNetwork);
            Sidebar.Controls.Add(btnJournal);
            Sidebar.FlowDirection = FlowDirection.TopDown;
            Sidebar.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Sidebar.Location = new Point(4, 45);
            Sidebar.Margin = new Padding(4);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(143, 640);
            Sidebar.TabIndex = 0;
            // 
            // btnManagement
            // 
            btnManagement.Anchor = AnchorStyles.Right;
            btnManagement.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnManagement.BackColor = Color.SkyBlue;
            btnManagement.BorderColor = Color.Black;
            btnManagement.BorderRadius = 11;
            btnManagement.BorderWidth = 1F;
            btnManagement.FlatStyle = FlatStyle.Flat;
            btnManagement.Font = new Font("Times New Roman", 14.25F);
            btnManagement.Location = new Point(4, 4);
            btnManagement.Margin = new Padding(4);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(132, 34);
            btnManagement.TabIndex = 0;
            btnManagement.TabStop = false;
            btnManagement.Text = "Управление";
            btnManagement.UseVisualStyleBackColor = false;
            btnManagement.Click += BtnManagement_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Right;
            btnSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSettings.BackColor = Color.SkyBlue;
            btnSettings.BorderColor = Color.Black;
            btnSettings.BorderRadius = 11;
            btnSettings.BorderWidth = 1F;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Times New Roman", 14.25F);
            btnSettings.Location = new Point(4, 46);
            btnSettings.Margin = new Padding(4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(132, 35);
            btnSettings.TabIndex = 1;
            btnSettings.TabStop = false;
            btnSettings.Text = "Настройки +";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += BtnSettings_Click;
            // 
            // btnGeneral
            // 
            btnGeneral.Anchor = AnchorStyles.Right;
            btnGeneral.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGeneral.BackColor = Color.SkyBlue;
            btnGeneral.BorderColor = Color.Black;
            btnGeneral.BorderRadius = 11;
            btnGeneral.BorderWidth = 1F;
            btnGeneral.FlatStyle = FlatStyle.Flat;
            btnGeneral.Font = new Font("Times New Roman", 14.25F);
            btnGeneral.Location = new Point(49, 89);
            btnGeneral.Margin = new Padding(4);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(87, 35);
            btnGeneral.TabIndex = 2;
            btnGeneral.TabStop = false;
            btnGeneral.Text = "Общие";
            btnGeneral.UseVisualStyleBackColor = false;
            btnGeneral.Visible = false;
            btnGeneral.Click += BtnGeneral_Click;
            // 
            // btnNetwork
            // 
            btnNetwork.Anchor = AnchorStyles.Right;
            btnNetwork.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNetwork.BackColor = Color.SkyBlue;
            btnNetwork.BorderColor = Color.Black;
            btnNetwork.BorderRadius = 11;
            btnNetwork.BorderWidth = 1F;
            btnNetwork.FlatStyle = FlatStyle.Flat;
            btnNetwork.Font = new Font("Times New Roman", 14.25F);
            btnNetwork.Location = new Point(49, 132);
            btnNetwork.Margin = new Padding(4);
            btnNetwork.Name = "btnNetwork";
            btnNetwork.Size = new Size(87, 35);
            btnNetwork.TabIndex = 3;
            btnNetwork.TabStop = false;
            btnNetwork.Text = "Сетевые";
            btnNetwork.UseVisualStyleBackColor = false;
            btnNetwork.Visible = false;
            btnNetwork.Click += BtnNetwork_Click;
            // 
            // btnJournal
            // 
            btnJournal.Anchor = AnchorStyles.Right;
            btnJournal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnJournal.BackColor = Color.SkyBlue;
            btnJournal.BorderColor = Color.Black;
            btnJournal.BorderRadius = 11;
            btnJournal.BorderWidth = 1F;
            btnJournal.FlatStyle = FlatStyle.Flat;
            btnJournal.Font = new Font("Times New Roman", 14.25F);
            btnJournal.Location = new Point(6, 175);
            btnJournal.Margin = new Padding(4);
            btnJournal.Name = "btnJournal";
            btnJournal.Size = new Size(130, 35);
            btnJournal.TabIndex = 4;
            btnJournal.TabStop = false;
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
            topPanel.Controls.Add(menuStrip);
            topPanel.Controls.Add(btnChangePassword);
            topPanel.Controls.Add(devicesLabel);
            topPanel.Controls.Add(btnWrite);
            topPanel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            topPanel.Location = new Point(4, 4);
            topPanel.Margin = new Padding(4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1512, 39);
            topPanel.TabIndex = 2;
            // 
            // menuStrip
            // 
            menuStrip.Anchor = AnchorStyles.None;
            menuStrip.BackColor = Color.Transparent;
            menuStrip.Dock = DockStyle.None;
            menuStrip.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip.GripStyle = ToolStripGripStyle.Visible;
            menuStrip.Items.AddRange(new ToolStripItem[] { helpMenu, UserHelp });
            menuStrip.Location = new Point(3, 3);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(9, 3, 0, 3);
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(343, 31);
            menuStrip.Stretch = false;
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
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.None;
            btnChangePassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnChangePassword.BackColor = Color.SkyBlue;
            btnChangePassword.BorderColor = Color.Black;
            btnChangePassword.BorderRadius = 11;
            btnChangePassword.BorderWidth = 1F;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Location = new Point(655, 3);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(161, 32);
            btnChangePassword.TabIndex = 87;
            btnChangePassword.TabStop = false;
            btnChangePassword.Text = "Изменить пароль";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // devicesLabel
            // 
            devicesLabel.Anchor = AnchorStyles.None;
            devicesLabel.AutoSize = true;
            devicesLabel.BackColor = Color.Transparent;
            devicesLabel.FlatStyle = FlatStyle.Flat;
            devicesLabel.Font = new Font("Times New Roman", 14.25F);
            devicesLabel.ForeColor = Color.Black;
            devicesLabel.Location = new Point(1316, 7);
            devicesLabel.Margin = new Padding(4, 0, 4, 0);
            devicesLabel.Name = "devicesLabel";
            devicesLabel.Size = new Size(102, 21);
            devicesLabel.TabIndex = 0;
            devicesLabel.Text = "Устройства";
            devicesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnWrite
            // 
            btnWrite.Anchor = AnchorStyles.None;
            btnWrite.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnWrite.BackColor = Color.SkyBlue;
            btnWrite.BorderColor = Color.Black;
            btnWrite.BorderRadius = 11;
            btnWrite.BorderWidth = 1F;
            btnWrite.FlatStyle = FlatStyle.Flat;
            btnWrite.Font = new Font("Times New Roman", 14.25F);
            btnWrite.ForeColor = Color.Black;
            btnWrite.Location = new Point(554, 3);
            btnWrite.Margin = new Padding(4);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(94, 32);
            btnWrite.TabIndex = 1;
            btnWrite.TabStop = false;
            btnWrite.Text = "Записать";
            btnWrite.UseVisualStyleBackColor = false;
            btnWrite.Click += BtnWrite_Click;
            // 
            // devicesPanel
            // 
            devicesPanel.Anchor = AnchorStyles.None;
            devicesPanel.AutoScroll = true;
            devicesPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            devicesPanel.BackColor = Color.LightGray;
            devicesPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            devicesPanel.ColumnCount = 1;
            devicesPanel.ColumnStyles.Add(new ColumnStyle());
            devicesPanel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            devicesPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            devicesPanel.Location = new Point(1216, 45);
            devicesPanel.Margin = new Padding(4);
            devicesPanel.Name = "devicesPanel";
            devicesPanel.RowCount = 1;
            devicesPanel.RowStyles.Add(new RowStyle());
            devicesPanel.Size = new Size(300, 640);
            devicesPanel.TabIndex = 1;
            // 
            // ChildFormPanel
            // 
            ChildFormPanel.Anchor = AnchorStyles.None;
            ChildFormPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChildFormPanel.BackColor = Color.Transparent;
            ChildFormPanel.BorderStyle = BorderStyle.FixedSingle;
            ChildFormPanel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChildFormPanel.Location = new Point(149, 45);
            ChildFormPanel.Margin = new Padding(4);
            ChildFormPanel.Name = "ChildFormPanel";
            ChildFormPanel.Size = new Size(1064, 640);
            ChildFormPanel.TabIndex = 4;
            // 
            // ConfiguratorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1520, 686);
            Controls.Add(devicesPanel);
            Controls.Add(Sidebar);
            Controls.Add(topPanel);
            Controls.Add(ChildFormPanel);
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
        }
        public Panel ChildFormPanel;
        public Label devicesLabel;
        public MenuStrip menuStrip;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem UserHelp;
        private RoundedButton btnChangePassword;
    }
}