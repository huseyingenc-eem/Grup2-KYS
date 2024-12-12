namespace KYS.UI.Forms.UserPanelForms
{
    partial class MyBorrowRecord
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
            txtSearch = new TextBox();
            dgvBorrowRecords = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecords).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(26, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(329, 32);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // dgvBorrowRecords
            // 
            dgvBorrowRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowRecords.Location = new Point(26, 92);
            dgvBorrowRecords.Name = "dgvBorrowRecords";
            dgvBorrowRecords.Size = new Size(693, 316);
            dgvBorrowRecords.TabIndex = 1;
            // 
            // MyBorrowRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBorrowRecords);
            Controls.Add(txtSearch);
            Name = "MyBorrowRecord";
            Text = "MyBorrowRecord";
            Load += MyBorrowRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private DataGridView dgvBorrowRecords;
    }
}