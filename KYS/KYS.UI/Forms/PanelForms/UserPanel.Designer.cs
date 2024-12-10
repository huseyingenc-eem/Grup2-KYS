namespace KYS.UI.Forms.PanelForms
{
    partial class UserPanel
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
            kitapİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kitapHakkındaToolStripMenuItem = new ToolStripMenuItem();
            ödünçAlmaEkranıToolStripMenuItem = new ToolStripMenuItem();
            adSoyadToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıBilgileriToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            işlemlerimToolStripMenuItem = new ToolStripMenuItem();
            ödünçAldığımKitaplarToolStripMenuItem = new ToolStripMenuItem();
            yazarHakkındaToolStripMenuItem = new ToolStripMenuItem();
            yazarBilgileriToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 20F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kitapİşlemleriToolStripMenuItem, adSoyadToolStripMenuItem, işlemlerimToolStripMenuItem, yazarHakkındaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1816, 45);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapHakkındaToolStripMenuItem, ödünçAlmaEkranıToolStripMenuItem });
            kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            kitapİşlemleriToolStripMenuItem.Size = new Size(197, 41);
            kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapHakkındaToolStripMenuItem
            // 
            kitapHakkındaToolStripMenuItem.Name = "kitapHakkındaToolStripMenuItem";
            kitapHakkındaToolStripMenuItem.Size = new Size(319, 42);
            kitapHakkındaToolStripMenuItem.Text = "Kitap Detayları";
            kitapHakkındaToolStripMenuItem.Click += kitapHakkındaToolStripMenuItem_Click;
            // 
            // ödünçAlmaEkranıToolStripMenuItem
            // 
            ödünçAlmaEkranıToolStripMenuItem.Name = "ödünçAlmaEkranıToolStripMenuItem";
            ödünçAlmaEkranıToolStripMenuItem.Size = new Size(319, 42);
            ödünçAlmaEkranıToolStripMenuItem.Text = "Ödünç Alma Ekranı";
            // 
            // adSoyadToolStripMenuItem
            // 
            adSoyadToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            adSoyadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kullanıcıBilgileriToolStripMenuItem, çıkışToolStripMenuItem });
            adSoyadToolStripMenuItem.Name = "adSoyadToolStripMenuItem";
            adSoyadToolStripMenuItem.Size = new Size(135, 41);
            adSoyadToolStripMenuItem.Text = "AdSoyad";
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            kullanıcıBilgileriToolStripMenuItem.Size = new Size(290, 42);
            kullanıcıBilgileriToolStripMenuItem.Text = "Kullanıcı Bilgileri";
            kullanıcıBilgileriToolStripMenuItem.Click += kullanıcıBilgileriToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(290, 42);
            çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // işlemlerimToolStripMenuItem
            // 
            işlemlerimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ödünçAldığımKitaplarToolStripMenuItem });
            işlemlerimToolStripMenuItem.Name = "işlemlerimToolStripMenuItem";
            işlemlerimToolStripMenuItem.Size = new Size(151, 41);
            işlemlerimToolStripMenuItem.Text = "İşlemlerim";
            // 
            // ödünçAldığımKitaplarToolStripMenuItem
            // 
            ödünçAldığımKitaplarToolStripMenuItem.Name = "ödünçAldığımKitaplarToolStripMenuItem";
            ödünçAldığımKitaplarToolStripMenuItem.Size = new Size(371, 42);
            ödünçAldığımKitaplarToolStripMenuItem.Text = "Ödünç Aldığım Kitaplar";
            ödünçAldığımKitaplarToolStripMenuItem.Click += ödünçAldığımKitaplarToolStripMenuItem_Click;
            // 
            // yazarHakkındaToolStripMenuItem
            // 
            yazarHakkındaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yazarBilgileriToolStripMenuItem });
            yazarHakkındaToolStripMenuItem.Name = "yazarHakkındaToolStripMenuItem";
            yazarHakkındaToolStripMenuItem.Size = new Size(209, 41);
            yazarHakkındaToolStripMenuItem.Text = "Yazar Hakkında";
            // 
            // yazarBilgileriToolStripMenuItem
            // 
            yazarBilgileriToolStripMenuItem.Name = "yazarBilgileriToolStripMenuItem";
            yazarBilgileriToolStripMenuItem.Size = new Size(252, 42);
            yazarBilgileriToolStripMenuItem.Text = "Yazar Bilgileri";
            yazarBilgileriToolStripMenuItem.Click += yazarBilgileriToolStripMenuItem_Click;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1816, 1069);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "UserPanel";
            Text = "UserPanel";
            FormClosing += UserPanel_FormClosing;
            Load += UserPanel_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kitapHakkındaToolStripMenuItem;
        private ToolStripMenuItem ödünçAlmaEkranıToolStripMenuItem;
        private ToolStripMenuItem adSoyadToolStripMenuItem;
        private ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem işlemlerimToolStripMenuItem;
        private ToolStripMenuItem ödünçAldığımKitaplarToolStripMenuItem;
        private ToolStripMenuItem yazarHakkındaToolStripMenuItem;
        private ToolStripMenuItem yazarBilgileriToolStripMenuItem;
    }
}