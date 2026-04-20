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
            deleteButton.BackColor = Color.SkyBlue;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Times New Roman", 12F);
            deleteButton.Location = new Point(24, 112);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(76, 31);
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
            connectButton.BackColor = Color.SkyBlue;
            connectButton.FlatStyle = FlatStyle.Flat;
            connectButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            connectButton.Location = new Point(104, 112);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(119, 31);
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
            ipLabel.Location = new Point(24, 45);
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
            placeLabel.Location = new Point(24, 76);
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
            switchLabelName.Location = new Point(24, 12);
            switchLabelName.Name = "switchLabelName";
            switchLabelName.Size = new Size(118, 19);
            switchLabelName.TabIndex = 8;
            switchLabelName.Text = "switchLabelName";
            switchLabelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeviceCard
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightGray;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(switchLabelName);
            Controls.Add(placeLabel);
            Controls.Add(connectButton);
            Controls.Add(deleteButton);
            Controls.Add(ipLabel);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.Black;
            Name = "DeviceCard";
            Size = new Size(244, 152);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label ipLabel;
        private Label placeLabel;
        private Label switchLabelName;
    }
}