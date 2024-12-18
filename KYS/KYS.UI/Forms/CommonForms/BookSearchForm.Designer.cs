namespace KYS.UI.Forms.UserPanelForms
{
    partial class BookSearchForm
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
            TreeNode treeNode1 = new TreeNode("Node2");
            TreeNode treeNode2 = new TreeNode("Node3");
            TreeNode treeNode3 = new TreeNode("Node4");
            TreeNode treeNode4 = new TreeNode("Node0", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Node1");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookSearchForm));
            flpBooks = new FlowLayoutPanel();
            txtBookSearch = new TextBox();
            treeViewBookType = new TreeView();
            SuspendLayout();
            // 
            // flpBooks
            // 
            flpBooks.BackColor = SystemColors.Control;
            flpBooks.Location = new Point(158, 41);
            flpBooks.Name = "flpBooks";
            flpBooks.Size = new Size(673, 626);
            flpBooks.TabIndex = 0;
            // 
            // txtBookSearch
            // 
            txtBookSearch.Location = new Point(158, 12);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(673, 23);
            txtBookSearch.TabIndex = 1;
            txtBookSearch.TextChanged += txtBookSearch_TextChanged;
            // 
            // treeViewBookType
            // 
            treeViewBookType.BackColor = Color.White;
            treeViewBookType.ForeColor = SystemColors.WindowText;
            treeViewBookType.Location = new Point(12, 12);
            treeViewBookType.Name = "treeViewBookType";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Node2";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Node3";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Node4";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Node1";
            treeViewBookType.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode5 });
            treeViewBookType.Size = new Size(140, 655);
            treeViewBookType.TabIndex = 2;
            treeViewBookType.AfterSelect += treeViewBookType_AfterSelect;
            // 
            // BookSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(849, 675);
            Controls.Add(treeViewBookType);
            Controls.Add(txtBookSearch);
            Controls.Add(flpBooks);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BookSearchForm";
            Text = "BookSearchForm";
            Load += BookSearchForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpBooks;
        private TextBox txtBookSearch;
        private TreeView treeViewBookType;
    }
}