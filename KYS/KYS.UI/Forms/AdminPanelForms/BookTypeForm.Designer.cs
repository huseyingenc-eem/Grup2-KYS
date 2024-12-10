namespace KYS.UI.Forms
{
    partial class BookTypeForm
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
            label1 = new Label();
            lstType = new ListBox();
            label2 = new Label();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(151, 68);
            txtName.Margin = new Padding(5, 6, 5, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 36);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 68);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 1;
            label1.Text = "Tür Adı     :";
            // 
            // lstType
            // 
            lstType.FormattingEnabled = true;
            lstType.ItemHeight = 30;
            lstType.Location = new Point(412, 62);
            lstType.Margin = new Padding(5, 6, 5, 6);
            lstType.Name = "lstType";
            lstType.Size = new Size(261, 334);
            lstType.TabIndex = 2;
            lstType.SelectedIndexChanged += lstType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 116);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 4;
            label2.Text = "Açıklama  :";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(151, 116);
            txtDescription.Margin = new Padding(5, 6, 5, 6);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(224, 179);
            txtDescription.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(271, 319);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 43);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(161, 319);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 43);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(51, 319);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 43);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(31, 19);
            lblWelcome.Margin = new Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(118, 30);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Tür Adı     :";
            // 
            // BookTypeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(703, 441);
            Controls.Add(lblWelcome);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(lstType);
            Controls.Add(label1);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "BookTypeForm";
            Text = "BookTypeForm";
            Load += BookTypeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private ListBox lstType;
        private Label label2;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lblWelcome;
    }
}