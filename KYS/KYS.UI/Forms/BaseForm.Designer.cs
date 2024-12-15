namespace KYS.UI.Forms
{
    partial class BaseForm
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
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 746);
            btnAdd.Margin = new Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(176, 70);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(229, 746);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 70);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(444, 746);
            btnUpdate.Margin = new Padding(5, 6, 5, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(176, 70);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1284, 881);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "BaseForm";
            Text = "BaseForm";
            Load += BaseForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
    }
}