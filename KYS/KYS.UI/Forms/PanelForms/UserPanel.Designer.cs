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
            kitapAraToolStripMenuItem = new ToolStripMenuItem();
            ödünçAlmaEkranıToolStripMenuItem = new ToolStripMenuItem();
            adSoyadToolStripMenuItem = new ToolStripMenuItem();
            yaptığımYorumlarToolStripMenuItem = new ToolStripMenuItem();
            ödünçAldığımKitaplarToolStripMenuItem1 = new ToolStripMenuItem();
            kullanıcıBilgileriToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            yazarHakkındaToolStripMenuItem = new ToolStripMenuItem();
            yazarBilgileriToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 20F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kitapİşlemleriToolStripMenuItem, adSoyadToolStripMenuItem, yazarHakkındaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2108, 45);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapAraToolStripMenuItem, ödünçAlmaEkranıToolStripMenuItem });
            kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            kitapİşlemleriToolStripMenuItem.Size = new Size(197, 41);
            kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapAraToolStripMenuItem
            // 
            kitapAraToolStripMenuItem.Name = "kitapAraToolStripMenuItem";
            kitapAraToolStripMenuItem.Size = new Size(319, 42);
            kitapAraToolStripMenuItem.Text = "Kitap Ana Sayfa";
            kitapAraToolStripMenuItem.Click += kitapAraToolStripMenuItem_Click;
            // 
            // ödünçAlmaEkranıToolStripMenuItem
            // 
            ödünçAlmaEkranıToolStripMenuItem.Name = "ödünçAlmaEkranıToolStripMenuItem";
            ödünçAlmaEkranıToolStripMenuItem.Size = new Size(319, 42);
            ödünçAlmaEkranıToolStripMenuItem.Text = "Ödünç Alma Ekranı";
            ödünçAlmaEkranıToolStripMenuItem.Click += ödünçAlmaEkranıToolStripMenuItem_Click;
            // 
            // adSoyadToolStripMenuItem
            // 
            adSoyadToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            adSoyadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yaptığımYorumlarToolStripMenuItem, ödünçAldığımKitaplarToolStripMenuItem1, kullanıcıBilgileriToolStripMenuItem, çıkışToolStripMenuItem });
            adSoyadToolStripMenuItem.Name = "adSoyadToolStripMenuItem";
            adSoyadToolStripMenuItem.Size = new Size(135, 41);
            adSoyadToolStripMenuItem.Text = "AdSoyad";
            // 
            // yaptığımYorumlarToolStripMenuItem
            // 
            yaptığımYorumlarToolStripMenuItem.Name = "yaptığımYorumlarToolStripMenuItem";
            yaptığımYorumlarToolStripMenuItem.Size = new Size(371, 42);
            yaptığımYorumlarToolStripMenuItem.Text = "Yorumlarım";
            yaptığımYorumlarToolStripMenuItem.Click += yaptığımYorumlarToolStripMenuItem_Click;
            // 
            // ödünçAldığımKitaplarToolStripMenuItem1
            // 
            ödünçAldığımKitaplarToolStripMenuItem1.Name = "ödünçAldığımKitaplarToolStripMenuItem1";
            ödünçAldığımKitaplarToolStripMenuItem1.Size = new Size(371, 42);
            ödünçAldığımKitaplarToolStripMenuItem1.Text = "Ödünç Aldığım Kitaplar";
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            kullanıcıBilgileriToolStripMenuItem.Size = new Size(371, 42);
            kullanıcıBilgileriToolStripMenuItem.Text = "Kullanıcı Bilgileri";
            kullanıcıBilgileriToolStripMenuItem.Click += kullanıcıBilgileriToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(371, 42);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
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
            ClientSize = new Size(2108, 1233);
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
        private ToolStripMenuItem ödünçAlmaEkranıToolStripMenuItem;
        private ToolStripMenuItem adSoyadToolStripMenuItem;
        private ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem yazarHakkındaToolStripMenuItem;
        private ToolStripMenuItem yazarBilgileriToolStripMenuItem;
        private ToolStripMenuItem kitapAraToolStripMenuItem;
        private ToolStripMenuItem yaptığımYorumlarToolStripMenuItem;
        private ToolStripMenuItem ödünçAldığımKitaplarToolStripMenuItem1;
    }
}