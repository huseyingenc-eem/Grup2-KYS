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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBorrowRecord));
            txtSearch = new TextBox();
            dgvBorrowRecords = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecords).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(304, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(362, 32);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvBorrowRecords
            // 
            dgvBorrowRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowRecords.Location = new Point(26, 92);
            dgvBorrowRecords.Name = "dgvBorrowRecords";
            dgvBorrowRecords.Size = new Size(640, 213);
            dgvBorrowRecords.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 2;
            label1.Text = "Ödünç Aldığım Kitaplar";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MyBorrowRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(699, 329);
            Controls.Add(label1);
            Controls.Add(dgvBorrowRecords);
            Controls.Add(txtSearch);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label label1;
    }
}