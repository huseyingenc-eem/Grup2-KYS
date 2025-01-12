﻿namespace KYS.UI.Forms.PanelForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            menuStrip1 = new MenuStrip();
            kitapİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kitapAraToolStripMenuItem = new ToolStripMenuItem();
            adSoyadToolStripMenuItem = new ToolStripMenuItem();
            yaptığımYorumlarToolStripMenuItem = new ToolStripMenuItem();
            ödünçAldığımKitaplarToolStripMenuItem1 = new ToolStripMenuItem();
            kullanıcıBilgileriToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            yazarHakkındaToolStripMenuItem = new ToolStripMenuItem();
            yazarBilgileriToolStripMenuItem = new ToolStripMenuItem();
            flpAnnouncements = new FlowLayoutPanel();
            label1 = new Label();
            panelForm = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.CadetBlue;
            menuStrip1.Font = new Font("Segoe UI", 20F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kitapİşlemleriToolStripMenuItem, adSoyadToolStripMenuItem, yazarHakkındaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1197, 45);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapAraToolStripMenuItem });
            kitapİşlemleriToolStripMenuItem.Image = (Image)resources.GetObject("kitapİşlemleriToolStripMenuItem.Image");
            kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            kitapİşlemleriToolStripMenuItem.Size = new Size(213, 41);
            kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapAraToolStripMenuItem
            // 
            kitapAraToolStripMenuItem.Name = "kitapAraToolStripMenuItem";
            kitapAraToolStripMenuItem.Size = new Size(279, 42);
            kitapAraToolStripMenuItem.Text = "Kitap Ana Sayfa";
            kitapAraToolStripMenuItem.Click += kitapAraToolStripMenuItem_Click;
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
            ödünçAldığımKitaplarToolStripMenuItem1.Click += ödünçAldığımKitaplarToolStripMenuItem1_Click;
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
            yazarHakkındaToolStripMenuItem.Image = (Image)resources.GetObject("yazarHakkındaToolStripMenuItem.Image");
            yazarHakkındaToolStripMenuItem.Name = "yazarHakkındaToolStripMenuItem";
            yazarHakkındaToolStripMenuItem.Size = new Size(225, 41);
            yazarHakkındaToolStripMenuItem.Text = "Yazar Hakkında";
            // 
            // yazarBilgileriToolStripMenuItem
            // 
            yazarBilgileriToolStripMenuItem.Name = "yazarBilgileriToolStripMenuItem";
            yazarBilgileriToolStripMenuItem.Size = new Size(252, 42);
            yazarBilgileriToolStripMenuItem.Text = "Yazar Bilgileri";
            yazarBilgileriToolStripMenuItem.Click += yazarBilgileriToolStripMenuItem_Click;
            // 
            // flpAnnouncements
            // 
            flpAnnouncements.Location = new Point(840, 114);
            flpAnnouncements.Name = "flpAnnouncements";
            flpAnnouncements.Size = new Size(356, 655);
            flpAnnouncements.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(840, 45);
            label1.Name = "label1";
            label1.Size = new Size(356, 78);
            label1.TabIndex = 5;
            label1.Text = "Duyurular";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelForm
            // 
            panelForm.Location = new Point(0, 42);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(843, 727);
            panelForm.TabIndex = 7;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1197, 767);
            Controls.Add(panelForm);
            Controls.Add(label1);
            Controls.Add(flpAnnouncements);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private ToolStripMenuItem adSoyadToolStripMenuItem;
        private ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem yazarHakkındaToolStripMenuItem;
        private ToolStripMenuItem yazarBilgileriToolStripMenuItem;
        private ToolStripMenuItem kitapAraToolStripMenuItem;
        private ToolStripMenuItem yaptığımYorumlarToolStripMenuItem;
        private ToolStripMenuItem ödünçAldığımKitaplarToolStripMenuItem1;
        private FlowLayoutPanel flpAnnouncements;
        private Label label1;
        private Panel panelForm;
    }
}