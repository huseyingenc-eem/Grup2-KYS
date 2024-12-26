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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCommentForm));
            dgvCommentRecords = new DataGridView();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCommentRecords).BeginInit();
            SuspendLayout();
            // 
            // dgvCommentRecords
            // 
            dgvCommentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommentRecords.Location = new Point(25, 101);
            dgvCommentRecords.Name = "dgvCommentRecords";
            dgvCommentRecords.Size = new Size(659, 348);
            dgvCommentRecords.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(25, 51);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(401, 32);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // MyCommentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(718, 483);
            Controls.Add(dgvCommentRecords);
            Controls.Add(txtSearch);
            Icon = (Icon)resources.GetObject("$this.Icon");
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