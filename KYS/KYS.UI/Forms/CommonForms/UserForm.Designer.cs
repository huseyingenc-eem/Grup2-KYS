namespace KYS.UI.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lstUsers = new ListBox();
            btnKaydet = new Button();
            btnGüncelle = new Button();
            btnSil = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15F);
            txtName.Location = new Point(218, 99);
            txtName.Margin = new Padding(5, 6, 5, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 34);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 15F);
            txtSurname.Location = new Point(218, 152);
            txtSurname.Margin = new Padding(5, 6, 5, 6);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(223, 34);
            txtSurname.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 15F);
            txtUserName.Location = new Point(218, 216);
            txtUserName.Margin = new Padding(5, 6, 5, 6);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(223, 34);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.Location = new Point(218, 284);
            txtPassword.Margin = new Padding(5, 6, 5, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(223, 34);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15F);
            txtEmail.Location = new Point(218, 346);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 34);
            txtEmail.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(33, 102);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 8;
            label1.Text = "ADI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(33, 152);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 9;
            label2.Text = "SOYADI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(31, 216);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 10;
            label3.Text = "KULLANICI ADI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(33, 284);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 11;
            label4.Text = "ŞİFRE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(33, 352);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 12;
            label5.Text = "EMAIL";
            // 
            // lstUsers
            // 
            lstUsers.DrawMode = DrawMode.OwnerDrawFixed;
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 30;
            lstUsers.Location = new Point(491, 102);
            lstUsers.Margin = new Padding(5, 6, 5, 6);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(354, 544);
            lstUsers.TabIndex = 15;
            lstUsers.MouseClick += lstUsers_MouseClick;
            lstUsers.DrawItem += lstUsers_DrawItem;
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
            lstUsers.MouseMove += lstUsers_MouseMove;
            // 
            // btnKaydet
            // 
            btnKaydet.Image = (Image)resources.GetObject("btnKaydet.Image");
            btnKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnKaydet.Location = new Point(341, 420);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(142, 46);
            btnKaydet.TabIndex = 17;
            btnKaydet.Text = "Kaydet";
            btnKaydet.TextAlign = ContentAlignment.MiddleRight;
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Image = (Image)resources.GetObject("btnGüncelle.Image");
            btnGüncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGüncelle.Location = new Point(33, 420);
            btnGüncelle.Margin = new Padding(3, 4, 3, 4);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(142, 46);
            btnGüncelle.TabIndex = 18;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Image = (Image)resources.GetObject("btnSil.Image");
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(193, 420);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(142, 46);
            btnSil.TabIndex = 19;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(887, 749);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstUsers);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 16F);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(9, 12, 9, 12);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lstUsers;
        private Button btnKaydet;
        private Button btnGüncelle;
        private Button btnSil;
    }
}