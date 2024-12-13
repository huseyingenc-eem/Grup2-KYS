namespace KYS.UI.Forms.UserPanelForms
{
    partial class MyCommentForm
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
            dgvCommentRecords = new DataGridView();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCommentRecords).BeginInit();
            SuspendLayout();
            // 
            // dgvCommentRecords
            // 
            dgvCommentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommentRecords.Location = new Point(54, 101);
            dgvCommentRecords.Name = "dgvCommentRecords";
            dgvCommentRecords.Size = new Size(693, 316);
            dgvCommentRecords.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(54, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(329, 32);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // MyCommentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCommentRecords);
            Controls.Add(txtSearch);
            Name = "MyCommentForm";
            Text = "MyCommentForm";
            Load += MyCommentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommentRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCommentRecords;
        private TextBox txtSearch;
    }
}