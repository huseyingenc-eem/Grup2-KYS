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
            lstListe = new ListBox();
            txtBirthDate = new MaskedTextBox();
            txtDeathDate = new MaskedTextBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
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
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 4;
            label2.Text = "Yazar Soyadı  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 160);
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
            txtName.Location = new Point(177, 40);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(277, 36);
            txtName.TabIndex = 10;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(177, 100);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(277, 36);
            txtSurname.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(177, 160);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(277, 36);
            txtCountry.TabIndex = 12;
            // 
            // txtBiography
            // 
            txtBiography.Location = new Point(177, 312);
            txtBiography.Margin = new Padding(3, 4, 3, 4);
            txtBiography.Multiline = true;
            txtBiography.Name = "txtBiography";
            txtBiography.Size = new Size(277, 181);
            txtBiography.TabIndex = 13;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(493, 40);
            pictureBoxPhoto.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(187, 200);
            pictureBoxPhoto.TabIndex = 16;
            pictureBoxPhoto.TabStop = false;
            pictureBoxPhoto.Click += pictureBoxPhoto_Click;
            pictureBoxPhoto.Paint += pictureBoxPhoto_Paint;
            // 
            // lstListe
            // 
            lstListe.DrawMode = DrawMode.OwnerDrawFixed;
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 30;
            lstListe.Location = new Point(493, 249);
            lstListe.Margin = new Padding(3, 4, 3, 4);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(187, 244);
            lstListe.TabIndex = 18;
            lstListe.MouseClick += lstListe_MouseClick;
            lstListe.DrawItem += lstListe_DrawItem;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            lstListe.MouseMove += lstListe_MouseMove;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(177, 210);
            txtBirthDate.Margin = new Padding(3, 4, 3, 4);
            txtBirthDate.Mask = "00/00/0000";
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(138, 36);
            txtBirthDate.TabIndex = 19;
            txtBirthDate.ValidatingType = typeof(DateTime);
            // 
            // txtDeathDate
            // 
            txtDeathDate.Location = new Point(177, 252);
            txtDeathDate.Margin = new Padding(3, 4, 3, 4);
            txtDeathDate.Mask = "00/00/0000";
            txtDeathDate.Name = "txtDeathDate";
            txtDeathDate.Size = new Size(138, 36);
            txtDeathDate.TabIndex = 20;
            txtDeathDate.ValidatingType = typeof(DateTime);
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(419, 501);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(122, 44);
            btnGuncelle.TabIndex = 34;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(288, 501);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(123, 44);
            btnSil.TabIndex = 33;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(558, 501);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(122, 44);
            btnEkle.TabIndex = 32;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // Authorform
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(729, 680);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtDeathDate);
            Controls.Add(txtBirthDate);
            Controls.Add(lstListe);
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
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Authorform";
            Text = "Authorform";
            Load += Authorform_Load;
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
        private ListBox lstListe;
        private MaskedTextBox txtBirthDate;
        private MaskedTextBox txtDeathDate;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
    }
}