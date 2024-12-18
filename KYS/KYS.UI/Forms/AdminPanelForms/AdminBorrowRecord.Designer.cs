namespace KYS.UI.Forms.AdminPanelForms
{
    partial class AdminBorrowRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBorrowRecord));
            dgvBorrowRecords = new DataGridView();
            txtSearch = new TextBox();
            btnReturn = new Button();
            cmbBooks = new ComboBox();
            btnGiveBook = new Button();
            txtBookName = new TextBox();
            lblBookName = new Label();
            label3 = new Label();
            txtCopiesAvailable = new TextBox();
            pbBookCover = new PictureBox();
            cmbSearch = new ComboBox();
            grbRecord = new GroupBox();
            grbKullanici = new GroupBox();
            cmbUsers = new ComboBox();
            txtName = new TextBox();
            label1 = new Label();
            txtMaxBorrow = new TextBox();
            label2 = new Label();
            btnDegistirme = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBookCover).BeginInit();
            grbRecord.SuspendLayout();
            grbKullanici.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBorrowRecords
            // 
            dgvBorrowRecords.BackgroundColor = SystemColors.ActiveCaption;
            dgvBorrowRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowRecords.Location = new Point(13, 74);
            dgvBorrowRecords.Name = "dgvBorrowRecords";
            dgvBorrowRecords.Size = new Size(648, 223);
            dgvBorrowRecords.TabIndex = 0;
            dgvBorrowRecords.CellContentClick += dgvBorrowRecords_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15F);
            txtSearch.Location = new Point(332, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(329, 34);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageAlign = ContentAlignment.MiddleLeft;
            btnReturn.Location = new Point(272, 336);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(212, 34);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "İade Al";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // cmbBooks
            // 
            cmbBooks.Font = new Font("Segoe UI", 15F);
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(410, 27);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(249, 36);
            cmbBooks.TabIndex = 3;
            cmbBooks.SelectedIndexChanged += cmbBooks_SelectedIndexChanged;
            // 
            // btnGiveBook
            // 
            btnGiveBook.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic);
            btnGiveBook.Location = new Point(490, 336);
            btnGiveBook.Name = "btnGiveBook";
            btnGiveBook.Size = new Size(212, 34);
            btnGiveBook.TabIndex = 4;
            btnGiveBook.Text = "Ödünç Ver";
            btnGiveBook.UseVisualStyleBackColor = true;
            btnGiveBook.Click += btnGiveBook_Click;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 10F);
            txtBookName.Location = new Point(516, 212);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(143, 25);
            txtBookName.TabIndex = 5;
            // 
            // lblBookName
            // 
            lblBookName.Font = new Font("Segoe UI", 10F);
            lblBookName.Location = new Point(410, 214);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(100, 23);
            lblBookName.TabIndex = 6;
            lblBookName.Text = "Kitabın Adı    :";
            lblBookName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(410, 254);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 10;
            label3.Text = "Kopya Sayısı  :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCopiesAvailable
            // 
            txtCopiesAvailable.Font = new Font("Segoe UI", 10F);
            txtCopiesAvailable.Location = new Point(516, 252);
            txtCopiesAvailable.Name = "txtCopiesAvailable";
            txtCopiesAvailable.Size = new Size(143, 25);
            txtCopiesAvailable.TabIndex = 9;
            // 
            // pbBookCover
            // 
            pbBookCover.Location = new Point(410, 69);
            pbBookCover.Name = "pbBookCover";
            pbBookCover.Size = new Size(249, 137);
            pbBookCover.SizeMode = PictureBoxSizeMode.Zoom;
            pbBookCover.TabIndex = 11;
            pbBookCover.TabStop = false;
            // 
            // cmbSearch
            // 
            cmbSearch.Font = new Font("Segoe UI", 15F);
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Items.AddRange(new object[] { "Tüm Kayıtlar", "Ayırtılan Kitapları Göster", "Ödünç Verilen Kitaplar", "Geçikmiş Kitaplar" });
            cmbSearch.Location = new Point(13, 34);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(313, 36);
            cmbSearch.TabIndex = 14;
            cmbSearch.SelectedIndexChanged += cmbSearch_SelectedIndexChanged;
            // 
            // grbRecord
            // 
            grbRecord.Controls.Add(dgvBorrowRecords);
            grbRecord.Controls.Add(cmbSearch);
            grbRecord.Controls.Add(txtSearch);
            grbRecord.Location = new Point(12, 13);
            grbRecord.Name = "grbRecord";
            grbRecord.Size = new Size(690, 317);
            grbRecord.TabIndex = 15;
            grbRecord.TabStop = false;
            grbRecord.Text = "Detaylı Arama";
            // 
            // grbKullanici
            // 
            grbKullanici.Controls.Add(cmbUsers);
            grbKullanici.Controls.Add(txtName);
            grbKullanici.Controls.Add(label1);
            grbKullanici.Controls.Add(txtMaxBorrow);
            grbKullanici.Controls.Add(label2);
            grbKullanici.Controls.Add(cmbBooks);
            grbKullanici.Controls.Add(txtBookName);
            grbKullanici.Controls.Add(pbBookCover);
            grbKullanici.Controls.Add(lblBookName);
            grbKullanici.Controls.Add(txtCopiesAvailable);
            grbKullanici.Controls.Add(label3);
            grbKullanici.Location = new Point(12, 379);
            grbKullanici.Name = "grbKullanici";
            grbKullanici.Size = new Size(690, 295);
            grbKullanici.TabIndex = 16;
            grbKullanici.TabStop = false;
            grbKullanici.Text = "Kitap Ödünç Vermek Ekranı";
            // 
            // cmbUsers
            // 
            cmbUsers.Font = new Font("Segoe UI", 15F);
            cmbUsers.FormattingEnabled = true;
            cmbUsers.Location = new Point(30, 27);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(249, 36);
            cmbUsers.TabIndex = 12;
            cmbUsers.SelectedIndexChanged += cmbUsers_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(136, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(143, 25);
            txtName.TabIndex = 13;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(30, 84);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 14;
            label1.Text = "Kullanıcı Adı  Soyadı  :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMaxBorrow
            // 
            txtMaxBorrow.Font = new Font("Segoe UI", 10F);
            txtMaxBorrow.Location = new Point(152, 122);
            txtMaxBorrow.Name = "txtMaxBorrow";
            txtMaxBorrow.Size = new Size(127, 25);
            txtMaxBorrow.TabIndex = 15;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(30, 122);
            label2.Name = "label2";
            label2.Size = new Size(116, 43);
            label2.TabIndex = 16;
            label2.Text = "Alabileceği Kitap sayisi  :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDegistirme
            // 
            btnDegistirme.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnDegistirme.ImageAlign = ContentAlignment.MiddleLeft;
            btnDegistirme.Location = new Point(12, 336);
            btnDegistirme.Name = "btnDegistirme";
            btnDegistirme.Size = new Size(212, 34);
            btnDegistirme.TabIndex = 17;
            btnDegistirme.Text = "Kitap Ayırtılmadıysa Tıklayınız";
            btnDegistirme.UseVisualStyleBackColor = true;
            btnDegistirme.Click += btnDegistirme_Click;
            // 
            // AdminBorrowRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(727, 686);
            Controls.Add(btnDegistirme);
            Controls.Add(grbKullanici);
            Controls.Add(grbRecord);
            Controls.Add(btnGiveBook);
            Controls.Add(btnReturn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminBorrowRecord";
            Text = "AdminBorrowRecord";
            Load += AdminBorrowRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBookCover).EndInit();
            grbRecord.ResumeLayout(false);
            grbRecord.PerformLayout();
            grbKullanici.ResumeLayout(false);
            grbKullanici.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBorrowRecords;
        private TextBox txtSearch;
        private Button btnReturn;
        private ComboBox cmbBooks;
        private Button btnGiveBook;
        private TextBox txtBookName;
        private Label lblBookName;
        private Label label3;
        private TextBox txtCopiesAvailable;
        private PictureBox pbBookCover;
        private ComboBox cmbSearch;
        private GroupBox grbRecord;
        private GroupBox grbKullanici;
        private ComboBox cmbUsers;
        private TextBox txtName;
        private Label label1;
        private TextBox txtMaxBorrow;
        private Label label2;
        private Button btnDegistirme;
    }
}