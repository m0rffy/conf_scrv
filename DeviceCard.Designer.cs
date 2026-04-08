namespace Uetm_2_0
{
    partial class DeviceCard
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
            placeTextBox = new TextBox();
            switchTextBox = new TextBox();
            deleteButton = new Button();
            connectButton = new Button();
            ipLabel = new Label();
            SuspendLayout();
            // 
            // placeTextBox
            // 
            placeTextBox.Anchor = AnchorStyles.None;
            placeTextBox.BorderStyle = BorderStyle.FixedSingle;
            placeTextBox.Font = new Font("Times New Roman", 12F);
            placeTextBox.Location = new Point(139, 43);
            placeTextBox.Name = "placeTextBox";
            placeTextBox.ReadOnly = true;
            placeTextBox.Size = new Size(190, 26);
            placeTextBox.TabIndex = 2;
            placeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // switchTextBox
            // 
            switchTextBox.Anchor = AnchorStyles.None;
            switchTextBox.BorderStyle = BorderStyle.FixedSingle;
            switchTextBox.Font = new Font("Times New Roman", 12F);
            switchTextBox.Location = new Point(139, 88);
            switchTextBox.Name = "switchTextBox";
            switchTextBox.ReadOnly = true;
            switchTextBox.Size = new Size(190, 26);
            switchTextBox.TabIndex = 4;
            switchTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.AutoSize = true;
            deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteButton.BackColor = Color.LightSkyBlue;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Times New Roman", 12F);
            deleteButton.Location = new Point(32, 86);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(74, 29);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // connectButton
            // 
            connectButton.Anchor = AnchorStyles.None;
            connectButton.AutoSize = true;
            connectButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            connectButton.BackColor = Color.LightSkyBlue;
            connectButton.FlatStyle = FlatStyle.Popup;
            connectButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            connectButton.Location = new Point(8, 42);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(117, 29);
            connectButton.TabIndex = 6;
            connectButton.Text = "Подключиться";
            connectButton.UseVisualStyleBackColor = false;
            connectButton.Click += connectButton_Click;
            // 
            // ipLabel
            // 
            ipLabel.Anchor = AnchorStyles.None;
            ipLabel.AutoSize = true;
            ipLabel.Font = new Font("Times New Roman", 12F);
            ipLabel.Location = new Point(139, 12);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new Size(23, 19);
            ipLabel.TabIndex = 0;
            ipLabel.Text = "IP";
            ipLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeviceCard
            // 
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightGray;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(connectButton);
            Controls.Add(deleteButton);
            Controls.Add(switchTextBox);
            Controls.Add(placeTextBox);
            Controls.Add(ipLabel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.Black;
            Name = "DeviceCard";
            Size = new Size(340, 134);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label ipLabel;
    }
}