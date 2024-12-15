namespace KYS.UI.Forms.AdminPanelForms
{
    partial class AdminBorrowRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBorrowRecord));
            dgvBorrowRecords = new DataGridView();
            txtSearch = new TextBox();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecords).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowRecords
            // 
            dgvBorrowRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowRecords.Location = new Point(33, 93);
            dgvBorrowRecords.Name = "dgvBorrowRecords";
            dgvBorrowRecords.Size = new Size(742, 392);
            dgvBorrowRecords.TabIndex = 0;
            dgvBorrowRecords.CellContentClick += dgvBorrowRecords_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15F);
            txtSearch.Location = new Point(33, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(524, 34);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageAlign = ContentAlignment.MiddleLeft;
            btnReturn.Location = new Point(563, 36);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(212, 34);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "İade Al";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // AdminBorrowRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 528);
            Controls.Add(btnReturn);
            Controls.Add(txtSearch);
            Controls.Add(dgvBorrowRecords);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminBorrowRecord";
            Text = "AdminBorrowRecord";
            Load += AdminBorrowRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBorrowRecords;
        private TextBox txtSearch;
        private Button btnReturn;
    }
}