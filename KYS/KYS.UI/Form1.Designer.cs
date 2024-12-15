namespace KYS.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLogin = new Button();
            txtUserName = new TextBox();
            lblKullanıcı = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblGiris = new Label();
            lnkCreateAccout = new LinkLabel();
            pictureKYS = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureKYS).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PowderBlue;
            btnLogin.Font = new Font("Segoe UI", 15F);
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(87, 338);
            btnLogin.Margin = new Padding(6, 7, 6, 7);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(222, 47);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 15F);
            txtUserName.ForeColor = SystemColors.ActiveCaption;
            txtUserName.Location = new Point(87, 214);
            txtUserName.Margin = new Padding(6, 7, 6, 7);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Kullanıcı Adınızı Giriniz";
            txtUserName.Size = new Size(222, 34);
            txtUserName.TabIndex = 1;
            // 
            // lblKullanıcı
            // 
            lblKullanıcı.AutoSize = true;
            lblKullanıcı.Font = new Font("Segoe UI", 10F);
            lblKullanıcı.ForeColor = SystemColors.ActiveCaptionText;
            lblKullanıcı.Location = new Point(87, 188);
            lblKullanıcı.Margin = new Padding(6, 0, 6, 0);
            lblKullanıcı.Name = "lblKullanıcı";
            lblKullanıcı.Size = new Size(82, 19);
            lblKullanıcı.TabIndex = 2;
            lblKullanıcı.Text = "Kullanıcı Adı";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.ForeColor = SystemColors.ActiveCaption;
            txtPassword.Location = new Point(87, 290);
            txtPassword.Margin = new Padding(6, 7, 6, 7);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Şifreniz";
            txtPassword.Size = new Size(222, 34);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblPassword.Location = new Point(87, 264);
            lblPassword.Margin = new Padding(6, 0, 6, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(52, 19);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Şifreniz";
            // 
            // lblGiris
            // 
            lblGiris.AutoSize = true;
            lblGiris.Location = new Point(87, 104);
            lblGiris.Margin = new Padding(6, 0, 6, 0);
            lblGiris.Name = "lblGiris";
            lblGiris.Size = new Size(0, 37);
            lblGiris.TabIndex = 5;
            // 
            // lnkCreateAccout
            // 
            lnkCreateAccout.AutoSize = true;
            lnkCreateAccout.Font = new Font("Segoe UI", 9F);
            lnkCreateAccout.LinkColor = Color.Black;
            lnkCreateAccout.Location = new Point(108, 392);
            lnkCreateAccout.Name = "lnkCreateAccout";
            lnkCreateAccout.Size = new Size(201, 15);
            lnkCreateAccout.TabIndex = 6;
            lnkCreateAccout.TabStop = true;
            lnkCreateAccout.Text = "Hesabınız yok mu? Hesap Oluşturun ";
            lnkCreateAccout.LinkClicked += lnkCreateAccout_LinkClicked;
            // 
            // pictureKYS
            // 
            pictureKYS.Image = Properties.Resources.KYS;
            pictureKYS.Location = new Point(87, 37);
            pictureKYS.Name = "pictureKYS";
            pictureKYS.Size = new Size(222, 148);
            pictureKYS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureKYS.TabIndex = 7;
            pictureKYS.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(404, 472);
            Controls.Add(pictureKYS);
            Controls.Add(lnkCreateAccout);
            Controls.Add(lblGiris);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblKullanıcı);
            Controls.Add(txtUserName);
            Controls.Add(btnLogin);
            Font = new Font("Segoe UI", 20F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureKYS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUserName;
        private Label lblKullanıcı;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblGiris;
        private LinkLabel lnkCreateAccout;
        private PictureBox pictureKYS;
    }
}
