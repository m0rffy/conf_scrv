namespace Uetm_2_0
{
    partial class UcJournal
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
            FlowLayoutPanel panelButtons;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            updateJournalButton = new Button();
            exportButton = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            journalDataGridView = new DataGridView();
            panelButtons = new FlowLayoutPanel();
            panelButtons.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)journalDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Anchor = AnchorStyles.None;
            panelButtons.AutoSize = true;
            panelButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelButtons.Controls.Add(updateJournalButton);
            panelButtons.Controls.Add(exportButton);
            panelButtons.FlowDirection = FlowDirection.TopDown;
            panelButtons.Location = new Point(405, 389);
            panelButtons.Margin = new Padding(4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(149, 74);
            panelButtons.TabIndex = 1;
            // 
            // updateJournalButton
            // 
            updateJournalButton.Anchor = AnchorStyles.None;
            updateJournalButton.AutoSize = true;
            updateJournalButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateJournalButton.BackColor = Color.SkyBlue;
            updateJournalButton.FlatStyle = FlatStyle.Popup;
            updateJournalButton.Font = new Font("Times New Roman", 12F);
            updateJournalButton.Location = new Point(4, 4);
            updateJournalButton.Margin = new Padding(4);
            updateJournalButton.Name = "updateJournalButton";
            updateJournalButton.Size = new Size(141, 29);
            updateJournalButton.TabIndex = 0;
            updateJournalButton.Text = "Обновить журнал";
            updateJournalButton.UseVisualStyleBackColor = false;
            updateJournalButton.Click += UpdateJournalButton_Click;
            // 
            // exportButton
            // 
            exportButton.Anchor = AnchorStyles.None;
            exportButton.AutoSize = true;
            exportButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exportButton.BackColor = Color.SkyBlue;
            exportButton.FlatStyle = FlatStyle.Popup;
            exportButton.Font = new Font("Times New Roman", 12F);
            exportButton.Location = new Point(36, 41);
            exportButton.Margin = new Padding(4);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(76, 29);
            exportButton.TabIndex = 1;
            exportButton.Text = "Экспорт";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += ExportButton_Click;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.Anchor = AnchorStyles.None;
            tableLayoutPanelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelMain.BackColor = Color.Transparent;
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.Controls.Add(journalDataGridView, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 1);
            tableLayoutPanelMain.ForeColor = Color.Black;
            tableLayoutPanelMain.Location = new Point(73, 36);
            tableLayoutPanelMain.Margin = new Padding(4);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(959, 475);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // journalDataGridView
            // 
            journalDataGridView.AllowUserToAddRows = false;
            journalDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            journalDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            journalDataGridView.Anchor = AnchorStyles.None;
            journalDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            journalDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            journalDataGridView.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            journalDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            journalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            journalDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            journalDataGridView.EnableHeadersVisualStyles = false;
            journalDataGridView.GridColor = Color.Gray;
            journalDataGridView.Location = new Point(4, 4);
            journalDataGridView.Margin = new Padding(4);
            journalDataGridView.Name = "journalDataGridView";
            journalDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            journalDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            journalDataGridView.RowHeadersVisible = false;
            journalDataGridView.RowHeadersWidth = 40;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            journalDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            journalDataGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            journalDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.Gainsboro;
            journalDataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            journalDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            journalDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            journalDataGridView.RowTemplate.ReadOnly = true;
            journalDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            journalDataGridView.Size = new Size(950, 370);
            journalDataGridView.TabIndex = 0;
            // 
            // UcJournal
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            Controls.Add(tableLayoutPanelMain);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "UcJournal";
            Size = new Size(1106, 549);
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)journalDataGridView).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button updateJournalButton;
        private Button exportButton;
        public TableLayoutPanel tableLayoutPanelMain;
        public DataGridView journalDataGridView;
    }
}