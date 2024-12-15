namespace KYS.UI.Forms
{
    partial class BookForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lstListe = new ListBox();
            txtName = new TextBox();
            txtPublishedYear = new TextBox();
            txtPages = new TextBox();
            txtCopiesAvailable = new TextBox();
            txtLanguage = new TextBox();
            txtDescription = new TextBox();
            cmbAuthor = new ComboBox();
            cmbType = new ComboBox();
            cmbPublisher = new ComboBox();
            pictureBoxPhoto = new PictureBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(153, 30);
            label1.TabIndex = 4;
            label1.Text = "Kitap Adı        :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 5;
            label2.Text = "Yazarı             :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(153, 30);
            label3.TabIndex = 6;
            label3.Text = "Kitap Türü      :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 172);
            label4.Name = "label4";
            label4.Size = new Size(150, 30);
            label4.TabIndex = 7;
            label4.Text = "Yayıncı Adı     :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 222);
            label5.Name = "label5";
            label5.Size = new Size(154, 30);
            label5.TabIndex = 8;
            label5.Text = "Yayın Yılı         :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 266);
            label7.Name = "label7";
            label7.Size = new Size(153, 30);
            label7.TabIndex = 10;
            label7.Text = "Sayfa Sayısı    :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 310);
            label8.Name = "label8";
            label8.Size = new Size(149, 30);
            label8.TabIndex = 11;
            label8.Text = "Kopya Sayısı  :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 350);
            label9.Name = "label9";
            label9.Size = new Size(204, 30);
            label9.TabIndex = 12;
            label9.Text = "Kitabın Yazıldığı Dil :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 391);
            label10.Name = "label10";
            label10.Size = new Size(179, 30);
            label10.TabIndex = 13;
            label10.Text = "Kitap Açıklaması :";
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 30;
            lstListe.Location = new Point(523, 299);
            lstListe.Margin = new Padding(3, 4, 3, 4);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(314, 304);
            lstListe.TabIndex = 16;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 32);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(335, 36);
            txtName.TabIndex = 17;
            // 
            // txtPublishedYear
            // 
            txtPublishedYear.Location = new Point(171, 219);
            txtPublishedYear.Margin = new Padding(3, 4, 3, 4);
            txtPublishedYear.Name = "txtPublishedYear";
            txtPublishedYear.Size = new Size(335, 36);
            txtPublishedYear.TabIndex = 18;
            // 
            // txtPages
            // 
            txtPages.Location = new Point(171, 263);
            txtPages.Margin = new Padding(3, 4, 3, 4);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(335, 36);
            txtPages.TabIndex = 20;
            // 
            // txtCopiesAvailable
            // 
            txtCopiesAvailable.Location = new Point(171, 307);
            txtCopiesAvailable.Margin = new Padding(3, 4, 3, 4);
            txtCopiesAvailable.Name = "txtCopiesAvailable";
            txtCopiesAvailable.Size = new Size(335, 36);
            txtCopiesAvailable.TabIndex = 21;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(219, 347);
            txtLanguage.Margin = new Padding(3, 4, 3, 4);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(287, 36);
            txtLanguage.TabIndex = 22;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(219, 391);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(287, 212);
            txtDescription.TabIndex = 23;
            // 
            // cmbAuthor
            // 
            cmbAuthor.FormattingEnabled = true;
            cmbAuthor.Location = new Point(171, 76);
            cmbAuthor.Margin = new Padding(3, 4, 3, 4);
            cmbAuthor.Name = "cmbAuthor";
            cmbAuthor.Size = new Size(335, 38);
            cmbAuthor.TabIndex = 24;
            cmbAuthor.SelectedIndexChanged += cmbAuthor_SelectedIndexChanged;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(171, 124);
            cmbType.Margin = new Padding(3, 4, 3, 4);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(335, 38);
            cmbType.TabIndex = 25;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // cmbPublisher
            // 
            cmbPublisher.FormattingEnabled = true;
            cmbPublisher.Location = new Point(171, 170);
            cmbPublisher.Margin = new Padding(3, 4, 3, 4);
            cmbPublisher.Name = "cmbPublisher";
            cmbPublisher.Size = new Size(335, 38);
            cmbPublisher.TabIndex = 26;
            cmbPublisher.SelectedIndexChanged += cmbPublisher_SelectedIndexChanged;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.BackColor = SystemColors.ControlLightLight;
            pictureBoxPhoto.Location = new Point(523, 32);
            pictureBoxPhoto.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(314, 256);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto.TabIndex = 28;
            pictureBoxPhoto.TabStop = false;
            pictureBoxPhoto.Click += pictureBoxPhoto_Click;
            pictureBoxPhoto.Paint += pictureBoxPhoto_Paint;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(394, 634);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(122, 44);
            btnEkle.TabIndex = 29;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(255, 634);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(123, 44);
            btnSil.TabIndex = 30;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(127, 634);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(122, 44);
            btnGuncelle.TabIndex = 31;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(933, 713);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(pictureBoxPhoto);
            Controls.Add(cmbPublisher);
            Controls.Add(cmbType);
            Controls.Add(cmbAuthor);
            Controls.Add(txtDescription);
            Controls.Add(txtLanguage);
            Controls.Add(txtCopiesAvailable);
            Controls.Add(txtPages);
            Controls.Add(txtPublishedYear);
            Controls.Add(txtName);
            Controls.Add(lstListe);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(9, 12, 9, 12);
            Name = "BookForm";
            Text = "BookAddForm";
            Load += BookForm_Load;
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListBox lstListe;
        private TextBox txtName;
        private TextBox txtPublishedYear;
        private TextBox txtPages;
        private TextBox txtCopiesAvailable;
        private TextBox txtLanguage;
        private TextBox txtDescription;
        private ComboBox cmbAuthor;
        private ComboBox cmbType;
        private ComboBox cmbPublisher;
        private PictureBox pictureBoxPhoto;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
    }
}