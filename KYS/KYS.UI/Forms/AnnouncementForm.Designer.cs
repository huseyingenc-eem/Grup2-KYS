namespace KYS.UI.Forms
{
    partial class AnnouncementForm
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
            label3 = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            lstListe = new ListBox();
            dtpDate = new DateTimePicker();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(36, 28);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 0;
            label1.Text = "Duyuru Başlığı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(36, 80);
            label2.Name = "label2";
            label2.Size = new Size(147, 30);
            label2.TabIndex = 1;
            label2.Text = "Duyuru Tarihi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(36, 137);
            label3.Name = "label3";
            label3.Size = new Size(154, 30);
            label3.TabIndex = 2;
            label3.Text = "Duyuru İçeriği :";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTitle.Location = new Point(234, 32);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(308, 29);
            txtTitle.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDescription.Location = new Point(234, 150);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(422, 306);
            txtDescription.TabIndex = 4;
            // 
            // lstListe
            // 
            lstListe.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 25;
            lstListe.Location = new Point(697, 32);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(325, 404);
            lstListe.TabIndex = 5;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpDate.Location = new Point(234, 81);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(308, 29);
            dtpDate.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(524, 496);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 54);
            btnSave.TabIndex = 7;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnDelete.Location = new Point(290, 496);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 54);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(72, 496);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 54);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // AnnouncementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 590);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(dtpDate);
            Controls.Add(lstListe);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AnnouncementForm";
            Text = "AnnouncementForm";
            Load += AnnouncementForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private ListBox lstListe;
        private DateTimePicker dtpDate;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
    }
}