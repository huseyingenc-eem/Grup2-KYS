namespace KYS.UI.Forms
{
    partial class PublisherForm
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
            txtName = new TextBox();
            txtCountry = new TextBox();
            lstListe = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 58);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 4;
            label1.Text = "Yayın Evi Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 145);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 5;
            label2.Text = "Ülkesi :";
            // 
            // txtName
            // 
            txtName.Location = new Point(201, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(374, 36);
            txtName.TabIndex = 6;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(201, 139);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(374, 36);
            txtCountry.TabIndex = 7;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 30;
            lstListe.Location = new Point(33, 225);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(542, 184);
            lstListe.TabIndex = 8;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // PublisherForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 889);
            Controls.Add(lstListe);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(9, 12, 9, 12);
            Name = "PublisherForm";
            Text = "PublisherForm";
            Load += PublisherForm_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(txtCountry, 0);
            Controls.SetChildIndex(lstListe, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtCountry;
        private ListBox lstListe;
    }
}