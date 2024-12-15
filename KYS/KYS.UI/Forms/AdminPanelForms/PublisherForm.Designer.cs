namespace KYS.UI.Forms
{
    partial class PublisherForm
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtCountry = new TextBox();
            lstListe = new ListBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 4;
            label1.Text = "Yayın Evi Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 135);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 5;
            label2.Text = "Ülkesi         :";
            // 
            // txtName
            // 
            txtName.Location = new Point(162, 56);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(316, 36);
            txtName.TabIndex = 6;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(162, 135);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(316, 36);
            txtCountry.TabIndex = 7;
            // 
            // lstListe
            // 
            lstListe.DrawMode = DrawMode.OwnerDrawFixed;
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 30;
            lstListe.Location = new Point(502, 47);
            lstListe.Margin = new Padding(3, 4, 3, 4);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(353, 484);
            lstListe.TabIndex = 8;
            lstListe.MouseClick += lstListe_MouseClick;
            lstListe.DrawItem += lstListe_DrawItem;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            lstListe.MouseMove += lstListe_MouseMove;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(143, 225);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 43);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(253, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 43);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(374, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 43);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // PublisherForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(887, 881);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstListe);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(9, 12, 9, 12);
            Name = "PublisherForm";
            Text = "PublisherForm";
            Load += PublisherForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtCountry;
        private ListBox lstListe;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
    }
}