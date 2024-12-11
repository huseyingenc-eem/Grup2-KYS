namespace KYS.UI.Forms.UserPanelForms
{
    partial class BookDetailForm
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
            pictureBoxCover = new PictureBox();
            grpBoxBookDetail = new GroupBox();
            btnBorrowBook = new Button();
            lblISBN = new Label();
            txtBookDescription = new TextBox();
            lblCopiesAvailable = new Label();
            lblBookPage = new Label();
            lblPublisherYear = new Label();
            lblPublisherName = new Label();
            lblAuthor = new Label();
            lblBookType = new Label();
            lblBookName = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            flpComments = new FlowLayoutPanel();
            txtBookSearch = new TextBox();
            lstBookListele = new ListBox();
            label7 = new Label();
            txtCommentContent = new TextBox();
            btnSubmitComment = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            grpBoxBookDetail.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxCover
            // 
            pictureBoxCover.Location = new Point(22, 90);
            pictureBoxCover.Name = "pictureBoxCover";
            pictureBoxCover.Size = new Size(199, 269);
            pictureBoxCover.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCover.TabIndex = 0;
            pictureBoxCover.TabStop = false;
            // 
            // grpBoxBookDetail
            // 
            grpBoxBookDetail.BackColor = SystemColors.ButtonFace;
            grpBoxBookDetail.Controls.Add(btnBorrowBook);
            grpBoxBookDetail.Controls.Add(lblISBN);
            grpBoxBookDetail.Controls.Add(txtBookDescription);
            grpBoxBookDetail.Controls.Add(lblCopiesAvailable);
            grpBoxBookDetail.Controls.Add(lblBookPage);
            grpBoxBookDetail.Controls.Add(lblPublisherYear);
            grpBoxBookDetail.Controls.Add(lblPublisherName);
            grpBoxBookDetail.Controls.Add(lblAuthor);
            grpBoxBookDetail.Controls.Add(lblBookType);
            grpBoxBookDetail.Controls.Add(lblBookName);
            grpBoxBookDetail.Controls.Add(label5);
            grpBoxBookDetail.Controls.Add(label6);
            grpBoxBookDetail.Controls.Add(label3);
            grpBoxBookDetail.Controls.Add(label4);
            grpBoxBookDetail.Controls.Add(label2);
            grpBoxBookDetail.Controls.Add(label1);
            grpBoxBookDetail.Controls.Add(pictureBoxCover);
            grpBoxBookDetail.Location = new Point(40, 152);
            grpBoxBookDetail.Name = "grpBoxBookDetail";
            grpBoxBookDetail.Size = new Size(559, 693);
            grpBoxBookDetail.TabIndex = 2;
            grpBoxBookDetail.TabStop = false;
            grpBoxBookDetail.Text = "Kitap Hakkında";
            // 
            // btnBorrowBook
            // 
            btnBorrowBook.Location = new Point(306, 629);
            btnBorrowBook.Name = "btnBorrowBook";
            btnBorrowBook.Size = new Size(232, 46);
            btnBorrowBook.TabIndex = 13;
            btnBorrowBook.Text = "Kitabı Ödünç Al";
            btnBorrowBook.UseVisualStyleBackColor = true;
            // 
            // lblISBN
            // 
            lblISBN.Font = new Font("Segoe UI", 10F);
            lblISBN.Location = new Point(240, 32);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(298, 42);
            lblISBN.TabIndex = 14;
            lblISBN.Text = "ISBN Numarası";
            lblISBN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBookDescription
            // 
            txtBookDescription.BackColor = SystemColors.ButtonFace;
            txtBookDescription.Location = new Point(22, 400);
            txtBookDescription.Multiline = true;
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.Size = new Size(516, 223);
            txtBookDescription.TabIndex = 13;
            // 
            // lblCopiesAvailable
            // 
            lblCopiesAvailable.Font = new Font("Segoe UI", 10F);
            lblCopiesAvailable.Location = new Point(437, 340);
            lblCopiesAvailable.Name = "lblCopiesAvailable";
            lblCopiesAvailable.Size = new Size(92, 19);
            lblCopiesAvailable.TabIndex = 12;
            // 
            // lblBookPage
            // 
            lblBookPage.Location = new Point(400, 290);
            lblBookPage.Name = "lblBookPage";
            lblBookPage.Size = new Size(138, 30);
            lblBookPage.TabIndex = 11;
            // 
            // lblPublisherYear
            // 
            lblPublisherYear.Location = new Point(400, 240);
            lblPublisherYear.Name = "lblPublisherYear";
            lblPublisherYear.Size = new Size(138, 30);
            lblPublisherYear.TabIndex = 10;
            // 
            // lblPublisherName
            // 
            lblPublisherName.Location = new Point(400, 190);
            lblPublisherName.Name = "lblPublisherName";
            lblPublisherName.Size = new Size(138, 30);
            lblPublisherName.TabIndex = 9;
            // 
            // lblAuthor
            // 
            lblAuthor.Location = new Point(400, 140);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(138, 30);
            lblAuthor.TabIndex = 8;
            // 
            // lblBookType
            // 
            lblBookType.Location = new Point(400, 90);
            lblBookType.Name = "lblBookType";
            lblBookType.Size = new Size(138, 30);
            lblBookType.TabIndex = 4;
            // 
            // lblBookName
            // 
            lblBookName.Location = new Point(22, 32);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(199, 42);
            lblBookName.TabIndex = 7;
            lblBookName.Text = "Kitabın Adı";
            lblBookName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(240, 340);
            label5.Name = "label5";
            label5.Size = new Size(191, 19);
            label5.TabIndex = 6;
            label5.Text = "Kütüphanedeki Kopya Sayısı : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 290);
            label6.Name = "label6";
            label6.Size = new Size(147, 30);
            label6.TabIndex = 5;
            label6.Text = "Sayfa Sayısı   :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 240);
            label3.Name = "label3";
            label3.Size = new Size(148, 30);
            label3.TabIndex = 4;
            label3.Text = "Yayın Yılı        :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 190);
            label4.Name = "label4";
            label4.Size = new Size(150, 30);
            label4.TabIndex = 3;
            label4.Text = "Yayıncı Adı     :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 140);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 2;
            label2.Text = "Kitabın Yazarı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 90);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 1;
            label1.Text = "Kitabın Türü   :";
            // 
            // flpComments
            // 
            flpComments.AutoScroll = true;
            flpComments.BackColor = SystemColors.ButtonFace;
            flpComments.FlowDirection = FlowDirection.TopDown;
            flpComments.Location = new Point(616, 83);
            flpComments.Name = "flpComments";
            flpComments.Size = new Size(337, 474);
            flpComments.TabIndex = 3;
            flpComments.WrapContents = false;
            // 
            // txtBookSearch
            // 
            txtBookSearch.Location = new Point(40, 12);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(559, 36);
            txtBookSearch.TabIndex = 5;
            txtBookSearch.TextChanged += txtBookSearch_TextChanged;
            // 
            // lstBookListele
            // 
            lstBookListele.FormattingEnabled = true;
            lstBookListele.ItemHeight = 30;
            lstBookListele.Location = new Point(40, 52);
            lstBookListele.Name = "lstBookListele";
            lstBookListele.Size = new Size(559, 94);
            lstBookListele.TabIndex = 6;
            lstBookListele.SelectedIndexChanged += lstBookListele_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.Location = new Point(619, 12);
            label7.Name = "label7";
            label7.Size = new Size(334, 68);
            label7.TabIndex = 8;
            label7.Text = "Kitaba Ait Yorumlar";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // txtCommentContent
            // 
            txtCommentContent.Location = new Point(619, 627);
            txtCommentContent.Multiline = true;
            txtCommentContent.Name = "txtCommentContent";
            txtCommentContent.Size = new Size(334, 148);
            txtCommentContent.TabIndex = 9;
            // 
            // btnSubmitComment
            // 
            btnSubmitComment.Location = new Point(619, 782);
            btnSubmitComment.Name = "btnSubmitComment";
            btnSubmitComment.Size = new Size(334, 45);
            btnSubmitComment.TabIndex = 10;
            btnSubmitComment.Text = "Yorum Eklemek İçin Basınız";
            btnSubmitComment.UseVisualStyleBackColor = true;
            btnSubmitComment.Click += btnSubmitComment_Click;
            // 
            // label8
            // 
            label8.Location = new Point(616, 573);
            label8.Name = "label8";
            label8.Size = new Size(334, 51);
            label8.TabIndex = 11;
            label8.Text = "Kitaba Hızlı Yorum Yaz";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(970, 870);
            Controls.Add(label8);
            Controls.Add(btnSubmitComment);
            Controls.Add(txtCommentContent);
            Controls.Add(lstBookListele);
            Controls.Add(label7);
            Controls.Add(txtBookSearch);
            Controls.Add(flpComments);
            Controls.Add(grpBoxBookDetail);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "BookDetailForm";
            Text = "BookDetailForm";
            Load += BookDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).EndInit();
            grpBoxBookDetail.ResumeLayout(false);
            grpBoxBookDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCover;
        private GroupBox grpBoxBookDetail;
        private Label label1;
        private FlowLayoutPanel flpComments;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label lblBookName;
        private Label lblBookType;
        private Label lblCopiesAvailable;
        private Label lblBookPage;
        private Label lblPublisherYear;
        private Label lblPublisherName;
        private Label lblAuthor;
        private Label lblISBN;
        private TextBox txtBookDescription;
        private Button btnBorrowBook;
        private TextBox txtBookSearch;
        private ListBox lstBookListele;
        private Label label7;
        private ComboBox cmbAuthor;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox txtCommentContent;
        private Button btnSubmitComment;
        private Label label8;
    }
}