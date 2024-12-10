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
            kitapEkleToolStripMenuItem = new ToolStripMenuItem();
            türEkleToolStripMenuItem = new ToolStripMenuItem();
            yayıncıİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            yayıncıEkleToolStripMenuItem = new ToolStripMenuItem();
            adSoyadToolStripMenuItem = new ToolStripMenuItem();
            duyuruEkleToolStripMenuItem = new ToolStripMenuItem();
            duyuruEkleToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 20F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kullanıcıİşlemleriToolStripMenuItem, kitapİşlemleriToolStripMenuItem, yayıncıİşlemleriToolStripMenuItem, adSoyadToolStripMenuItem, duyuruEkleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1941, 45);
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
            kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapEkleToolStripMenuItem, türEkleToolStripMenuItem });
            kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            kitapİşlemleriToolStripMenuItem.Size = new Size(197, 41);
            kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
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
            adSoyadToolStripMenuItem.Name = "adSoyadToolStripMenuItem";
            adSoyadToolStripMenuItem.Size = new Size(142, 41);
            adSoyadToolStripMenuItem.Text = "Ad Soyad";
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
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1941, 984);
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
    }
}