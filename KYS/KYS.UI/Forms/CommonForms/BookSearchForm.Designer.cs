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
            label1 = new Label();
            SuspendLayout();
            // 
            // flpBooks
            // 
            flpBooks.BackColor = SystemColors.Control;
            flpBooks.Location = new Point(214, 151);
            flpBooks.Name = "flpBooks";
            flpBooks.Size = new Size(651, 698);
            flpBooks.TabIndex = 0;
            // 
            // txtBookSearch
            // 
            txtBookSearch.Location = new Point(214, 122);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(651, 23);
            txtBookSearch.TabIndex = 1;
            txtBookSearch.TextChanged += txtBookSearch_TextChanged;
            // 
            // treeViewBookType
            // 
            treeViewBookType.BackColor = Color.White;
            treeViewBookType.ForeColor = SystemColors.WindowText;
            treeViewBookType.Location = new Point(12, 122);
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
            treeViewBookType.Size = new Size(196, 727);
            treeViewBookType.TabIndex = 2;
            treeViewBookType.AfterSelect += treeViewBookType_AfterSelect;
            // 
            // label1
            // 
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(727, 110);
            label1.TabIndex = 3;
            label1.Text = "Kitap Arama Ekranı";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(887, 749);
            Controls.Add(label1);
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
        private Label label1;
    }
}