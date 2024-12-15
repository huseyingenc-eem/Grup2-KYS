namespace KYS.UI.Forms.UserPanelForms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            groupBox1 = new GroupBox();
            txtPassword = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            btnUpdate = new Button();
            txtUserName = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 503);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üyelik Bilgilerim";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 290);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(374, 35);
            txtPassword.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(6, 298);
            label4.Name = "label4";
            label4.Size = new Size(65, 30);
            label4.TabIndex = 9;
            label4.Text = "Şifre :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 226);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(374, 35);
            txtEmail.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(6, 234);
            label6.Name = "label6";
            label6.Size = new Size(74, 30);
            label6.TabIndex = 7;
            label6.Text = "Email :";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(324, 366);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(200, 38);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(150, 167);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(374, 35);
            txtUserName.TabIndex = 5;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(150, 105);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(374, 35);
            txtSurname.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(374, 35);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 170);
            label3.Name = "label3";
            label3.Size = new Size(138, 30);
            label3.TabIndex = 2;
            label3.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 108);
            label2.Name = "label2";
            label2.Size = new Size(80, 30);
            label2.TabIndex = 1;
            label2.Text = "Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(50, 30);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(680, 564);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUpdate;
        private TextBox txtUserName;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtPassword;
        private Label label4;
    }
}