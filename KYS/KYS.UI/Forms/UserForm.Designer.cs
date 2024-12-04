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
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            numLimit = new NumericUpDown();
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lstUsers = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numLimit).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15F);
            txtName.Location = new Point(498, 148);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 34);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 15F);
            txtSurname.Location = new Point(498, 189);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(229, 34);
            txtSurname.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 15F);
            txtUserName.Location = new Point(498, 237);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(229, 34);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.Location = new Point(498, 293);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 34);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15F);
            txtEmail.Location = new Point(498, 341);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 34);
            txtEmail.TabIndex = 4;
            // 
            // numLimit
            // 
            numLimit.Font = new Font("Segoe UI", 15F);
            numLimit.Location = new Point(556, 390);
            numLimit.Name = "numLimit";
            numLimit.Size = new Size(168, 34);
            numLimit.TabIndex = 5;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 15F);
            btnKaydet.Location = new Point(357, 438);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(154, 44);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(357, 148);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 8;
            label1.Text = "ADI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(350, 189);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 9;
            label2.Text = "SOYADI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(350, 237);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 10;
            label3.Text = "KULLANICI ADI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(350, 299);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 11;
            label4.Text = "ŞİFRE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(350, 344);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 12;
            label5.Text = "EMAIL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(350, 392);
            label6.Name = "label6";
            label6.Size = new Size(200, 28);
            label6.TabIndex = 13;
            label6.Text = "ÖDÜNÇ ALMA SAYISI";
            // 
            // lstUsers
            // 
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 15;
            lstUsers.Location = new Point(733, 148);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(179, 349);
            lstUsers.TabIndex = 15;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1175, 648);
            Controls.Add(lstUsers);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(numLimit);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)numLimit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private NumericUpDown numLimit;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox lstUsers;
    }
}