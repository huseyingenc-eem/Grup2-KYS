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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowRecordForm));
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
            pictureBoxPhoto.Location = new Point(37, 107);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(303, 307);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto.TabIndex = 0;
            pictureBoxPhoto.TabStop = false;
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Location = new Point(545, 230);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(259, 29);
            dtpBorrowDate.TabIndex = 1;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(546, 286);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(259, 29);
            dtpReturnDate.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(583, 55);
            label1.TabIndex = 3;
            label1.Text = "Kitap Ödünç Alma";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBookName.Location = new Point(35, 495);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(97, 25);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Kitap Adı :";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAuthor.Location = new Point(35, 559);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(99, 25);
            lblAuthor.TabIndex = 5;
            lblAuthor.Text = "Yazar Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(348, 90);
            label4.Name = "label4";
            label4.Size = new Size(331, 32);
            label4.TabIndex = 6;
            label4.Text = "Kitabı Alacak Kullanıcı Bilgileri";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblUserName.Location = new Point(348, 171);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(191, 25);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "Kullanıcı Adı              :";
            // 
            // lblBorrowDate
            // 
            lblBorrowDate.AutoSize = true;
            lblBorrowDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBorrowDate.Location = new Point(348, 230);
            lblBorrowDate.Name = "lblBorrowDate";
            lblBorrowDate.Size = new Size(191, 25);
            lblBorrowDate.TabIndex = 9;
            lblBorrowDate.Text = "Ödünç Alma Tarihi    :";
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDeliveryDate.Location = new Point(348, 290);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(192, 25);
            lblDeliveryDate.TabIndex = 10;
            lblDeliveryDate.Text = "En Geç Teslim Tarihi  :";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(142, 491);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(198, 29);
            txtBookName.TabIndex = 11;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(142, 555);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(198, 29);
            txtAuthorName.TabIndex = 12;
            // 
            // txtUserName
            // 
            txtUserName.Enabled = false;
            txtUserName.Location = new Point(546, 171);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(259, 29);
            txtUserName.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientActiveCaption;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(624, 631);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(215, 40);
            btnSave.TabIndex = 14;
            btnSave.Text = "Kitabı Ödünç Al";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.GradientActiveCaption;
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCancel.Location = new Point(400, 631);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 40);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = SystemColors.GradientActiveCaption;
            lblMessage.Location = new Point(400, 370);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(439, 240);
            lblMessage.TabIndex = 17;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BorrowRecordForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(887, 749);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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