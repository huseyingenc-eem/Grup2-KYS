namespace KYS.UI.Forms
{
    partial class Authorform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorform));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtCountry = new TextBox();
            txtBiography = new TextBox();
            pictureBoxPhoto = new PictureBox();
            btnSelectPhoto = new Button();
            lstListe = new ListBox();
            txtBirthDate = new MaskedTextBox();
            txtDeathDate = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(154, 30);
            label1.TabIndex = 3;
            label1.Text = "Yazar Adı        :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 4;
            label2.Text = "Yazar Soyadı  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(153, 30);
            label3.TabIndex = 5;
            label3.Text = "Ülkesi             :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(159, 30);
            label4.TabIndex = 6;
            label4.Text = "Doğum Tarihi : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 256);
            label5.Name = "label5";
            label5.Size = new Size(152, 30);
            label5.TabIndex = 7;
            label5.Text = "Ölüm Tarihi    :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 314);
            label6.Name = "label6";
            label6.Size = new Size(154, 30);
            label6.TabIndex = 8;
            label6.Text = "Biyografisi      :";
            // 
            // txtName
            // 
            txtName.Location = new Point(177, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(277, 36);
            txtName.TabIndex = 10;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(177, 100);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(277, 36);
            txtSurname.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(177, 161);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(277, 36);
            txtCountry.TabIndex = 12;
            // 
            // txtBiography
            // 
            txtBiography.Location = new Point(177, 311);
            txtBiography.Multiline = true;
            txtBiography.Name = "txtBiography";
            txtBiography.Size = new Size(277, 242);
            txtBiography.TabIndex = 13;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(516, 39);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(298, 201);
            pictureBoxPhoto.TabIndex = 16;
            pictureBoxPhoto.TabStop = false;
            // 
            // btnSelectPhoto
            // 
            btnSelectPhoto.Image = (Image)resources.GetObject("btnSelectPhoto.Image");
            btnSelectPhoto.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelectPhoto.Location = new Point(666, 249);
            btnSelectPhoto.Name = "btnSelectPhoto";
            btnSelectPhoto.Size = new Size(148, 43);
            btnSelectPhoto.TabIndex = 17;
            btnSelectPhoto.Text = "Resim Ekle";
            btnSelectPhoto.TextAlign = ContentAlignment.MiddleRight;
            btnSelectPhoto.UseVisualStyleBackColor = true;
            btnSelectPhoto.Click += btnSelectPhoto_Click;
            // 
            // lstListe
            // 
            lstListe.DrawMode = DrawMode.OwnerDrawFixed;
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 30;
            lstListe.Location = new Point(478, 316);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(336, 394);
            lstListe.TabIndex = 18;
            lstListe.MouseClick += lstListe_MouseClick;
            lstListe.DrawItem += lstListe_DrawItem;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            lstListe.MouseMove += lstListe_MouseMove;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(177, 210);
            txtBirthDate.Mask = "00/00/0000";
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(137, 36);
            txtBirthDate.TabIndex = 19;
            txtBirthDate.ValidatingType = typeof(DateTime);
            // 
            // txtDeathDate
            // 
            txtDeathDate.Location = new Point(177, 252);
            txtDeathDate.Mask = "00/00/0000";
            txtDeathDate.Name = "txtDeathDate";
            txtDeathDate.Size = new Size(137, 36);
            txtDeathDate.TabIndex = 20;
            txtDeathDate.ValidatingType = typeof(DateTime);
            // 
            // Authorform
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(887, 749);
            Controls.Add(txtDeathDate);
            Controls.Add(txtBirthDate);
            Controls.Add(lstListe);
            Controls.Add(btnSelectPhoto);
            Controls.Add(pictureBoxPhoto);
            Controls.Add(txtBiography);
            Controls.Add(txtCountry);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Authorform";
            Text = "Authorform";
            Load += Authorform_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(txtSurname, 0);
            Controls.SetChildIndex(txtCountry, 0);
            Controls.SetChildIndex(txtBiography, 0);
            Controls.SetChildIndex(pictureBoxPhoto, 0);
            Controls.SetChildIndex(btnSelectPhoto, 0);
            Controls.SetChildIndex(lstListe, 0);
            Controls.SetChildIndex(txtBirthDate, 0);
            Controls.SetChildIndex(txtDeathDate, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtCountry;
        private TextBox txtBiography;
        private PictureBox pictureBoxPhoto;
        private Button btnSelectPhoto;
        private ListBox lstListe;
        private MaskedTextBox txtBirthDate;
        private MaskedTextBox txtDeathDate;
    }
}