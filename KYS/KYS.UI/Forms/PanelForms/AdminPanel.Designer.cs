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
            menuStrip1 = new MenuStrip();
            kullanıcıİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıTakipEtmeToolStripMenuItem = new ToolStripMenuItem();
            kitapİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kitapAraToolStripMenuItem = new ToolStripMenuItem();
            kitapEkleToolStripMenuItem = new ToolStripMenuItem();
            türEkleToolStripMenuItem = new ToolStripMenuItem();
            yayıncıİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            yayıncıEkleToolStripMenuItem = new ToolStripMenuItem();
            adSoyadToolStripMenuItem = new ToolStripMenuItem();
            adminBilgileriToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            duyuruEkleToolStripMenuItem = new ToolStripMenuItem();
            duyuruEkleToolStripMenuItem1 = new ToolStripMenuItem();
            button1 = new Button();
            lblBook = new Label();
            lblUser = new Label();
            lblType = new Label();
            lblPublisher = new Label();
            lblAnnouncement = new Label();
            lblAuthor = new Label();
            yazarEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 20F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kullanıcıİşlemleriToolStripMenuItem, kitapİşlemleriToolStripMenuItem, yayıncıİşlemleriToolStripMenuItem, adSoyadToolStripMenuItem, duyuruEkleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1444, 45);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kullanıcıTakipEtmeToolStripMenuItem });
            kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            kullanıcıİşlemleriToolStripMenuItem.Size = new Size(235, 41);
            kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // kullanıcıTakipEtmeToolStripMenuItem
            // 
            kullanıcıTakipEtmeToolStripMenuItem.Name = "kullanıcıTakipEtmeToolStripMenuItem";
            kullanıcıTakipEtmeToolStripMenuItem.Size = new Size(329, 42);
            kullanıcıTakipEtmeToolStripMenuItem.Text = "Kullanıcı Takip Etme";
            kullanıcıTakipEtmeToolStripMenuItem.Click += kullanıcıTakipEtmeToolStripMenuItem_Click;
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapAraToolStripMenuItem, kitapEkleToolStripMenuItem, türEkleToolStripMenuItem, yazarEkleToolStripMenuItem });
            kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            kitapİşlemleriToolStripMenuItem.Size = new Size(197, 41);
            kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapAraToolStripMenuItem
            // 
            kitapAraToolStripMenuItem.Name = "kitapAraToolStripMenuItem";
            kitapAraToolStripMenuItem.Size = new Size(211, 42);
            kitapAraToolStripMenuItem.Text = "Kitap Ara";
            kitapAraToolStripMenuItem.Click += kitapAraToolStripMenuItem_Click;
            // 
            // kitapEkleToolStripMenuItem
            // 
            kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            kitapEkleToolStripMenuItem.Size = new Size(211, 42);
            kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            kitapEkleToolStripMenuItem.Click += kitapEkleToolStripMenuItem_Click;
            // 
            // türEkleToolStripMenuItem
            // 
            türEkleToolStripMenuItem.Name = "türEkleToolStripMenuItem";
            türEkleToolStripMenuItem.Size = new Size(211, 42);
            türEkleToolStripMenuItem.Text = "Tür Ekle";
            türEkleToolStripMenuItem.Click += türEkleToolStripMenuItem_Click;
            // 
            // yayıncıİşlemleriToolStripMenuItem
            // 
            yayıncıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yayıncıEkleToolStripMenuItem });
            yayıncıİşlemleriToolStripMenuItem.Name = "yayıncıİşlemleriToolStripMenuItem";
            yayıncıİşlemleriToolStripMenuItem.Size = new Size(216, 41);
            yayıncıİşlemleriToolStripMenuItem.Text = "Yayıncı İşlemleri";
            // 
            // yayıncıEkleToolStripMenuItem
            // 
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
            adSoyadToolStripMenuItem.Size = new Size(142, 41);
            adSoyadToolStripMenuItem.Text = "Ad Soyad";
            // 
            // adminBilgileriToolStripMenuItem
            // 
            adminBilgileriToolStripMenuItem.Name = "adminBilgileriToolStripMenuItem";
            adminBilgileriToolStripMenuItem.Size = new Size(268, 42);
            adminBilgileriToolStripMenuItem.Text = "Admin Bilgileri";
            adminBilgileriToolStripMenuItem.Click += adminBilgileriToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(268, 42);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // duyuruEkleToolStripMenuItem
            // 
            duyuruEkleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { duyuruEkleToolStripMenuItem1 });
            duyuruEkleToolStripMenuItem.Name = "duyuruEkleToolStripMenuItem";
            duyuruEkleToolStripMenuItem.Size = new Size(221, 41);
            duyuruEkleToolStripMenuItem.Text = "Duyuru İşlemleri";
            // 
            // duyuruEkleToolStripMenuItem1
            // 
            duyuruEkleToolStripMenuItem1.Name = "duyuruEkleToolStripMenuItem1";
            duyuruEkleToolStripMenuItem1.Size = new Size(235, 42);
            duyuruEkleToolStripMenuItem1.Text = "Duyuru Ekle";
            duyuruEkleToolStripMenuItem1.Click += duyuruEkleToolStripMenuItem1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(578, 431);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblBook
            // 
            lblBook.BackColor = Color.LightSeaGreen;
            lblBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBook.Location = new Point(27, 66);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(181, 126);
            lblBook.TabIndex = 5;
            lblBook.Text = "Kitap Sayısı :";
            // 
            // lblUser
            // 
            lblUser.BackColor = Color.LightSeaGreen;
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblUser.Location = new Point(238, 66);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(181, 126);
            lblUser.TabIndex = 6;
            lblUser.Text = "Kullanıcı Sayısı :";
            // 
            // lblType
            // 
            lblType.BackColor = Color.LightSeaGreen;
            lblType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblType.Location = new Point(446, 66);
            lblType.Name = "lblType";
            lblType.Size = new Size(181, 126);
            lblType.TabIndex = 7;
            lblType.Text = "Kitap Tür Sayısı :";
            // 
            // lblPublisher
            // 
            lblPublisher.BackColor = Color.LightSeaGreen;
            lblPublisher.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPublisher.Location = new Point(27, 229);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(181, 126);
            lblPublisher.TabIndex = 8;
            lblPublisher.Text = "Yayıncı Sayısı :";
            // 
            // lblAnnouncement
            // 
            lblAnnouncement.BackColor = Color.LightSeaGreen;
            lblAnnouncement.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAnnouncement.Location = new Point(238, 229);
            lblAnnouncement.Name = "lblAnnouncement";
            lblAnnouncement.Size = new Size(181, 126);
            lblAnnouncement.TabIndex = 9;
            lblAnnouncement.Text = "Duyuru Sayısı :";
            // 
            // lblAuthor
            // 
            lblAuthor.BackColor = Color.LightSeaGreen;
            lblAuthor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAuthor.Location = new Point(446, 229);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(181, 126);
            lblAuthor.TabIndex = 10;
            lblAuthor.Text = "Yazar Sayısı :";
            // 
            // yazarEkleToolStripMenuItem
            // 
            yazarEkleToolStripMenuItem.Name = "yazarEkleToolStripMenuItem";
            yazarEkleToolStripMenuItem.Size = new Size(211, 42);
            yazarEkleToolStripMenuItem.Text = "Yazar Ekle";
            yazarEkleToolStripMenuItem.Click += yazarEkleToolStripMenuItem_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 881);
            Controls.Add(lblAuthor);
            Controls.Add(lblAnnouncement);
            Controls.Add(lblPublisher);
            Controls.Add(lblType);
            Controls.Add(lblUser);
            Controls.Add(lblBook);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AdminPanel";
            Text = "AdminPanel";
            FormClosing += AdminPanel_FormClosing;
            Load += AdminPanel_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
        private Label lblBook;
        private Label lblUser;
        private Label lblType;
        private Label lblPublisher;
        private Label lblAnnouncement;
        private Label lblAuthor;
        private ToolStripMenuItem yazarEkleToolStripMenuItem;
    }
}