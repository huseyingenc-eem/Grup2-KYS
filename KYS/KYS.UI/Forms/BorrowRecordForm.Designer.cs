namespace KYS.UI.Forms
{
    partial class BorrowRecordForm
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
            pictureBoxPhoto = new PictureBox();
            dtpBorrowDate = new DateTimePicker();
            dtpReturnDate = new DateTimePicker();
            label1 = new Label();
            lblBookName = new Label();
            lblAuthor = new Label();
            label4 = new Label();
            lblUserName = new Label();
            lblBorrowDate = new Label();
            lblDeliveryDate = new Label();
            txtBookName = new TextBox();
            txtAuthorName = new TextBox();
            txtUserName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(37, 54);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(196, 197);
            pictureBoxPhoto.TabIndex = 0;
            pictureBoxPhoto.TabStop = false;
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Location = new Point(402, 128);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(220, 29);
            dtpBorrowDate.TabIndex = 1;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(402, 163);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(220, 29);
            dtpReturnDate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(185, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 37);
            label1.TabIndex = 3;
            label1.Text = "Kitap Ödünç Alma";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(36, 269);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(79, 21);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Kitap Adı :";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(34, 304);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(81, 21);
            lblAuthor.TabIndex = 5;
            lblAuthor.Text = "Yazar Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(252, 54);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 6;
            label4.Text = "Kullanıcı Bilgileri";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(252, 101);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(98, 21);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "Kullanıcı Adı:";
            // 
            // lblBorrowDate
            // 
            lblBorrowDate.AutoSize = true;
            lblBorrowDate.Location = new Point(252, 136);
            lblBorrowDate.Name = "lblBorrowDate";
            lblBorrowDate.Size = new Size(144, 21);
            lblBorrowDate.TabIndex = 9;
            lblBorrowDate.Text = "Ödünç Alma Tarihi :";
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(252, 169);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(101, 21);
            lblDeliveryDate.TabIndex = 10;
            lblDeliveryDate.Text = "Teslim Tarihi :";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(121, 266);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(146, 29);
            txtBookName.TabIndex = 11;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(121, 304);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(146, 29);
            txtAuthorName.TabIndex = 12;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(356, 95);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(266, 29);
            txtUserName.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(302, 286);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 47);
            btnSave.TabIndex = 14;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(459, 286);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 47);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(252, 195);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(370, 56);
            lblMessage.TabIndex = 17;
            // 
            // BorrowRecordForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(646, 366);
            Controls.Add(lblMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtUserName);
            Controls.Add(txtAuthorName);
            Controls.Add(txtBookName);
            Controls.Add(lblDeliveryDate);
            Controls.Add(lblBorrowDate);
            Controls.Add(lblUserName);
            Controls.Add(label4);
            Controls.Add(lblAuthor);
            Controls.Add(lblBookName);
            Controls.Add(label1);
            Controls.Add(dtpReturnDate);
            Controls.Add(dtpBorrowDate);
            Controls.Add(pictureBoxPhoto);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "BorrowRecordForm";
            Text = "BorrowRecordForm";
            Load += BorrowRecordForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPhoto;
        private DateTimePicker dtpBorrowDate;
        private DateTimePicker dtpReturnDate;
        private Label label1;
        private Label lblBookName;
        private Label lblAuthor;
        private Label label4;
        private Label lblUserName;
        private Label lblBorrowDate;
        private Label lblDeliveryDate;
        private TextBox txtBookName;
        private TextBox txtAuthorName;
        private TextBox txtUserName;
        private Button btnSave;
        private Button btnCancel;
        private Label lblMessage;
    }
}