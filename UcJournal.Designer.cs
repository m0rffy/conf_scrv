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
            panelButtons.Location = new Point(451, 395);
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
            updateJournalButton.BackColor = Color.LightSteelBlue;
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
            exportButton.BackColor = Color.LightSteelBlue;
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
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.Controls.Add(journalDataGridView, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelButtons, 0, 1);
            tableLayoutPanelMain.ForeColor = Color.Black;
            tableLayoutPanelMain.Location = new Point(15, 23);
            tableLayoutPanelMain.Margin = new Padding(4);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(1051, 480);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // journalDataGridView
            // 
            journalDataGridView.AllowUserToAddRows = false;
            journalDataGridView.AllowUserToDeleteRows = false;
            journalDataGridView.Anchor = AnchorStyles.None;
            journalDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            journalDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            journalDataGridView.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            journalDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            journalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            journalDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            journalDataGridView.GridColor = Color.Gainsboro;
            journalDataGridView.Location = new Point(51, 4);
            journalDataGridView.Margin = new Padding(4);
            journalDataGridView.Name = "journalDataGridView";
            journalDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            journalDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            journalDataGridView.RowHeadersVisible = false;
            journalDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            journalDataGridView.Size = new Size(949, 377);
            journalDataGridView.TabIndex = 0;
            // 
            // UcJournal
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanelMain);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "UcJournal";
            Size = new Size(1104, 547);
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