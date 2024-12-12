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
            label1 = new Label();
            label2 = new Label();
            cmbBook = new ComboBox();
            label3 = new Label();
            cmbUser = new ComboBox();
            label4 = new Label();
            dtpDueDate = new DateTimePicker();
            label6 = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnMarkReturned = new Button();
            dgvRecords = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(15, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 31);
            label1.TabIndex = 0;
            label1.Text = "Kitap ve Kullanıcı Seçimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(15, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 1;
            label2.Text = "Kitap Seçiniz:";
            // 
            // cmbBook
            // 
            cmbBook.Font = new Font("Segoe UI", 12F);
            cmbBook.FormattingEnabled = true;
            cmbBook.Location = new Point(122, 91);
            cmbBook.Margin = new Padding(4);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(273, 29);
            cmbBook.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 154);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 3;
            label3.Text = "Kullanıcı Seçiniz:";
            // 
            // cmbUser
            // 
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(155, 146);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(240, 29);
            cmbUser.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 214);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 5;
            label4.Text = "İade Edilecek Tarih:";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(170, 206);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(225, 29);
            dtpDueDate.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(417, 91);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 9;
            label6.Text = "Durum:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(15, 307);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 46);
            btnSave.TabIndex = 11;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(155, 307);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 46);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnDelete.Location = new Point(286, 307);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 46);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMarkReturned
            // 
            btnMarkReturned.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnMarkReturned.Location = new Point(417, 307);
            btnMarkReturned.Name = "btnMarkReturned";
            btnMarkReturned.Size = new Size(102, 46);
            btnMarkReturned.TabIndex = 14;
            btnMarkReturned.Text = "İade Al";
            btnMarkReturned.UseVisualStyleBackColor = true;
            btnMarkReturned.Click += btnMarkReturned_Click;
            // 
            // dgvRecords
            // 
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(485, 91);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.Size = new Size(240, 150);
            dgvRecords.TabIndex = 15;
            // 
            // BorrowRecordForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 414);
            Controls.Add(dgvRecords);
            Controls.Add(btnMarkReturned);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(dtpDueDate);
            Controls.Add(label4);
            Controls.Add(cmbUser);
            Controls.Add(label3);
            Controls.Add(cmbBook);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "BorrowRecordForm";
            Text = "BorrowRecordForm";
            Load += BorrowRecordForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbBook;
        private Label label3;
        private ComboBox cmbUser;
        private Label label4;
        private DateTimePicker dtpDueDate;
        private Label label6;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnMarkReturned;
        private DataGridView dgvRecords;
    }
}