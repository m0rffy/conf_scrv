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
            deleteButton = new Button();
            connectButton = new Button();
            ipLabel = new Label();
            placeLabel = new Label();
            switchLabelName = new Label();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.AutoSize = true;
            deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteButton.BackColor = Color.LightSteelBlue;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Times New Roman", 12F);
            deleteButton.Location = new Point(17, 106);
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
            connectButton.BackColor = Color.LightSteelBlue;
            connectButton.FlatStyle = FlatStyle.Popup;
            connectButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            connectButton.Location = new Point(97, 106);
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
            ipLabel.FlatStyle = FlatStyle.System;
            ipLabel.Font = new Font("Times New Roman", 12F);
            ipLabel.Location = new Point(17, 40);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new Size(23, 19);
            ipLabel.TabIndex = 0;
            ipLabel.Text = "IP";
            ipLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // placeLabel
            // 
            placeLabel.Anchor = AnchorStyles.None;
            placeLabel.AutoSize = true;
            placeLabel.FlatStyle = FlatStyle.System;
            placeLabel.Location = new Point(17, 71);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new Size(75, 19);
            placeLabel.TabIndex = 7;
            placeLabel.Text = "placeLabel";
            placeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // switchLabelName
            // 
            switchLabelName.Anchor = AnchorStyles.None;
            switchLabelName.AutoSize = true;
            switchLabelName.FlatStyle = FlatStyle.System;
            switchLabelName.Location = new Point(17, 9);
            switchLabelName.Name = "switchLabelName";
            switchLabelName.Size = new Size(118, 19);
            switchLabelName.TabIndex = 8;
            switchLabelName.Text = "switchLabelName";
            switchLabelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeviceCard
            // 
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Gainsboro;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(switchLabelName);
            Controls.Add(placeLabel);
            Controls.Add(connectButton);
            Controls.Add(deleteButton);
            Controls.Add(ipLabel);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.Black;
            Name = "DeviceCard";
            Size = new Size(230, 151);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label ipLabel;
        private Label placeLabel;
        private Label switchLabelName;
    }
}