namespace KYS.UI.Forms.PanelForms
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            menuStrip1 = new MenuStrip();
            kullanıcıİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıTakipEtmeToolStripMenuItem = new ToolStripMenuItem();
            kitapİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kitapAraToolStripMenuItem = new ToolStripMenuItem();
            kitapEkleToolStripMenuItem = new ToolStripMenuItem();
            türEkleToolStripMenuItem = new ToolStripMenuItem();
            yazarEkleToolStripMenuItem = new ToolStripMenuItem();
            yayıncıİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            yayıncıEkleToolStripMenuItem = new ToolStripMenuItem();
            adSoyadToolStripMenuItem = new ToolStripMenuItem();
            adminBilgileriToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            duyuruEkleToolStripMenuItem = new ToolStripMenuItem();
            duyuruEkleToolStripMenuItem1 = new ToolStripMenuItem();
            raporToolStripMenuItem = new ToolStripMenuItem();
            ödünçAlınanKitaplarToolStripMenuItem = new ToolStripMenuItem();
            lblBook = new Label();
            lblUser = new Label();
            lblType = new Label();
            lblPublisher = new Label();
            lblAnnouncement = new Label();
            lblAuthor = new Label();
            pnlForms = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblHeader = new Label();
            pnlYardimci = new Panel();
            lblDetail = new Label();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.CadetBlue;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 20F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kullanıcıİşlemleriToolStripMenuItem, kitapİşlemleriToolStripMenuItem, yayıncıİşlemleriToolStripMenuItem, adSoyadToolStripMenuItem, duyuruEkleToolStripMenuItem, raporToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(246, 184);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(310, 666);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            kullanıcıİşlemleriToolStripMenuItem.BackColor = Color.CadetBlue;
            kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kullanıcıTakipEtmeToolStripMenuItem });
            kullanıcıİşlemleriToolStripMenuItem.Image = (Image)resources.GetObject("kullanıcıİşlemleriToolStripMenuItem.Image");
            kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            kullanıcıİşlemleriToolStripMenuItem.Size = new Size(303, 41);
            kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // kullanıcıTakipEtmeToolStripMenuItem
            // 
            kullanıcıTakipEtmeToolStripMenuItem.BackColor = Color.CadetBlue;
            kullanıcıTakipEtmeToolStripMenuItem.Name = "kullanıcıTakipEtmeToolStripMenuItem";
            kullanıcıTakipEtmeToolStripMenuItem.Size = new Size(329, 42);
            kullanıcıTakipEtmeToolStripMenuItem.Text = "Kullanıcı Takip Etme";
            kullanıcıTakipEtmeToolStripMenuItem.Click += kullanıcıTakipEtmeToolStripMenuItem_Click;
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            kitapİşlemleriToolStripMenuItem.BackColor = Color.CadetBlue;
            kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapAraToolStripMenuItem, kitapEkleToolStripMenuItem, türEkleToolStripMenuItem, yazarEkleToolStripMenuItem });
            kitapİşlemleriToolStripMenuItem.Image = (Image)resources.GetObject("kitapİşlemleriToolStripMenuItem.Image");
            kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            kitapİşlemleriToolStripMenuItem.Size = new Size(303, 41);
            kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapAraToolStripMenuItem
            // 
            kitapAraToolStripMenuItem.BackColor = Color.CadetBlue;
            kitapAraToolStripMenuItem.Name = "kitapAraToolStripMenuItem";
            kitapAraToolStripMenuItem.Size = new Size(211, 42);
            kitapAraToolStripMenuItem.Text = "Kitap Ara";
            kitapAraToolStripMenuItem.Click += kitapAraToolStripMenuItem_Click;
            // 
            // kitapEkleToolStripMenuItem
            // 
            kitapEkleToolStripMenuItem.BackColor = Color.CadetBlue;
            kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            kitapEkleToolStripMenuItem.Size = new Size(211, 42);
            kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            kitapEkleToolStripMenuItem.Click += kitapEkleToolStripMenuItem_Click;
            // 
            // türEkleToolStripMenuItem
            // 
            türEkleToolStripMenuItem.BackColor = Color.CadetBlue;
            türEkleToolStripMenuItem.Name = "türEkleToolStripMenuItem";
            türEkleToolStripMenuItem.Size = new Size(211, 42);
            türEkleToolStripMenuItem.Text = "Tür Ekle";
            türEkleToolStripMenuItem.Click += türEkleToolStripMenuItem_Click;
            // 
            // yazarEkleToolStripMenuItem
            // 
            yazarEkleToolStripMenuItem.BackColor = Color.CadetBlue;
            yazarEkleToolStripMenuItem.Name = "yazarEkleToolStripMenuItem";
            yazarEkleToolStripMenuItem.Size = new Size(211, 42);
            yazarEkleToolStripMenuItem.Text = "Yazar Ekle";
            yazarEkleToolStripMenuItem.Click += yazarEkleToolStripMenuItem_Click;
            // 
            // yayıncıİşlemleriToolStripMenuItem
            // 
            yayıncıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yayıncıEkleToolStripMenuItem });
            yayıncıİşlemleriToolStripMenuItem.Image = (Image)resources.GetObject("yayıncıİşlemleriToolStripMenuItem.Image");
            yayıncıİşlemleriToolStripMenuItem.Name = "yayıncıİşlemleriToolStripMenuItem";
            yayıncıİşlemleriToolStripMenuItem.Size = new Size(303, 41);
            yayıncıİşlemleriToolStripMenuItem.Text = "Yayıncı İşlemleri";
            // 
            // yayıncıEkleToolStripMenuItem
            // 
            yayıncıEkleToolStripMenuItem.BackColor = Color.CadetBlue;
            yayıncıEkleToolStripMenuItem.Name = "yayıncıEkleToolStripMenuItem";
            yayıncıEkleToolStripMenuItem.Size = new Size(230, 42);
            yayıncıEkleToolStripMenuItem.Text = "Yayıncı Ekle";
            yayıncıEkleToolStripMenuItem.Click += yayıncıEkleToolStripMenuItem_Click;
            // 
            // adSoyadToolStripMenuItem
            // 
            adSoyadToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            adSoyadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminBilgileriToolStripMenuItem, çıkışYapToolStripMenuItem });
            adSoyadToolStripMenuItem.Name = "adSoyadToolStripMenuItem";
            adSoyadToolStripMenuItem.Size = new Size(303, 41);
            adSoyadToolStripMenuItem.Text = "Ad Soyad";
            // 
            // adminBilgileriToolStripMenuItem
            // 
            adminBilgileriToolStripMenuItem.BackColor = Color.CadetBlue;
            adminBilgileriToolStripMenuItem.Name = "adminBilgileriToolStripMenuItem";
            adminBilgileriToolStripMenuItem.Size = new Size(268, 42);
            adminBilgileriToolStripMenuItem.Text = "Admin Bilgileri";
            adminBilgileriToolStripMenuItem.Click += adminBilgileriToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.BackColor = Color.CadetBlue;
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(268, 42);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // duyuruEkleToolStripMenuItem
            // 
            duyuruEkleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { duyuruEkleToolStripMenuItem1 });
            duyuruEkleToolStripMenuItem.Image = (Image)resources.GetObject("duyuruEkleToolStripMenuItem.Image");
            duyuruEkleToolStripMenuItem.Name = "duyuruEkleToolStripMenuItem";
            duyuruEkleToolStripMenuItem.Size = new Size(303, 41);
            duyuruEkleToolStripMenuItem.Text = "Duyuru İşlemleri";
            // 
            // duyuruEkleToolStripMenuItem1
            // 
            duyuruEkleToolStripMenuItem1.BackColor = Color.CadetBlue;
            duyuruEkleToolStripMenuItem1.Name = "duyuruEkleToolStripMenuItem1";
            duyuruEkleToolStripMenuItem1.Size = new Size(235, 42);
            duyuruEkleToolStripMenuItem1.Text = "Duyuru Ekle";
            duyuruEkleToolStripMenuItem1.Click += duyuruEkleToolStripMenuItem1_Click;
            // 
            // raporToolStripMenuItem
            // 
            raporToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ödünçAlınanKitaplarToolStripMenuItem });
            raporToolStripMenuItem.Image = (Image)resources.GetObject("raporToolStripMenuItem.Image");
            raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            raporToolStripMenuItem.Size = new Size(303, 41);
            raporToolStripMenuItem.Text = "Rapor";
            // 
            // ödünçAlınanKitaplarToolStripMenuItem
            // 
            ödünçAlınanKitaplarToolStripMenuItem.BackColor = Color.CadetBlue;
            ödünçAlınanKitaplarToolStripMenuItem.Name = "ödünçAlınanKitaplarToolStripMenuItem";
            ödünçAlınanKitaplarToolStripMenuItem.Size = new Size(353, 42);
            ödünçAlınanKitaplarToolStripMenuItem.Text = "Ödünç Alınan Kitaplar";
            ödünçAlınanKitaplarToolStripMenuItem.Click += ödünçAlınanKitaplarToolStripMenuItem_Click;
            // 
            // lblBook
            // 
            lblBook.BackColor = Color.FromArgb(192, 192, 255);
            lblBook.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBook.Location = new Point(21, 497);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(187, 83);
            lblBook.TabIndex = 5;
            lblBook.Text = "Kitap Sayısı :";
            lblBook.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.BackColor = Color.FromArgb(192, 192, 255);
            lblUser.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblUser.Location = new Point(21, 20);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(187, 83);
            lblUser.TabIndex = 6;
            lblUser.Text = "Kullanıcı Sayısı :";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            lblType.BackColor = Color.FromArgb(192, 192, 255);
            lblType.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblType.Location = new Point(21, 264);
            lblType.Name = "lblType";
            lblType.Size = new Size(187, 83);
            lblType.TabIndex = 7;
            lblType.Text = "Kitap Tür Sayısı :";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublisher
            // 
            lblPublisher.BackColor = Color.FromArgb(192, 192, 255);
            lblPublisher.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPublisher.Location = new Point(21, 613);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(187, 83);
            lblPublisher.TabIndex = 8;
            lblPublisher.Text = "Yayıncı Sayısı :";
            lblPublisher.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAnnouncement
            // 
            lblAnnouncement.BackColor = Color.FromArgb(192, 192, 255);
            lblAnnouncement.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAnnouncement.Location = new Point(21, 141);
            lblAnnouncement.Name = "lblAnnouncement";
            lblAnnouncement.Size = new Size(187, 83);
            lblAnnouncement.TabIndex = 9;
            lblAnnouncement.Text = "Duyuru Sayısı :";
            lblAnnouncement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            lblAuthor.BackColor = Color.FromArgb(192, 192, 255);
            lblAuthor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAuthor.Location = new Point(21, 376);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(187, 83);
            lblAuthor.TabIndex = 10;
            lblAuthor.Text = "Yazar Sayısı :";
            lblAuthor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlForms
            // 
            pnlForms.BackColor = Color.CadetBlue;
            pnlForms.Location = new Point(551, 149);
            pnlForms.Name = "pnlForms";
            pnlForms.Size = new Size(818, 701);
            pnlForms.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(246, -7);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 196);
            panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CadetBlue;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.KYS;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(lblAnnouncement);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(lblAuthor);
            panel1.Controls.Add(lblPublisher);
            panel1.Controls.Add(lblBook);
            panel1.Controls.Add(lblType);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 850);
            panel1.TabIndex = 16;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.CadetBlue;
            lblHeader.Font = new Font("Segoe UI", 40F);
            lblHeader.Location = new Point(551, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(818, 157);
            lblHeader.TabIndex = 18;
            lblHeader.Text = "Admin Paneli";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlYardimci
            // 
            pnlYardimci.BackColor = Color.CadetBlue;
            pnlYardimci.Location = new Point(1366, 141);
            pnlYardimci.Name = "pnlYardimci";
            pnlYardimci.Size = new Size(833, 709);
            pnlYardimci.TabIndex = 20;
            // 
            // lblDetail
            // 
            lblDetail.BackColor = Color.CadetBlue;
            lblDetail.Font = new Font("Segoe UI", 40F);
            lblDetail.Location = new Point(1369, 0);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(846, 167);
            lblDetail.TabIndex = 21;
            lblDetail.Text = "Admin Paneli";
            lblDetail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2309, 850);
            Controls.Add(pnlYardimci);
            Controls.Add(lblDetail);
            Controls.Add(lblHeader);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnlForms);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AdminPanel";
            Text = "AdminPanel";
            FormClosing += AdminPanel_FormClosing;
            Load += AdminPanel_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private ToolStripMenuItem yayıncıİşlemleriToolStripMenuItem;
        private ToolStripMenuItem adSoyadToolStripMenuItem;
        private ToolStripMenuItem kullanıcıTakipEtmeToolStripMenuItem;
        private ToolStripMenuItem kitapEkleToolStripMenuItem;
        private ToolStripMenuItem türEkleToolStripMenuItem;
        private ToolStripMenuItem duyuruEkleToolStripMenuItem;
        private ToolStripMenuItem duyuruEkleToolStripMenuItem1;
        private ToolStripMenuItem yayıncıEkleToolStripMenuItem;
        private ToolStripMenuItem adminBilgileriToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem kitapAraToolStripMenuItem;
        private Label lblBook;
        private Label lblUser;
        private Label lblType;
        private Label lblPublisher;
        private Label lblAnnouncement;
        private Label lblAuthor;
        private ToolStripMenuItem yazarEkleToolStripMenuItem;
        private Panel pnlForms;
        private ToolStripMenuItem raporToolStripMenuItem;
        private ToolStripMenuItem ödünçAlınanKitaplarToolStripMenuItem;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblHeader;
        private Panel pnlYardimci;
        private Label lblDetail;
    }
}