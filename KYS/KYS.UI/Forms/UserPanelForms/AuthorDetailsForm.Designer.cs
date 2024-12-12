namespace KYS.UI.Forms
{
    partial class AuthorDetailsForm
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
            txtAra = new TextBox();
            label1 = new Label();
            lstYazar = new ListBox();
            lstKitap = new ListBox();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtAra
            // 
            txtAra.Location = new Point(115, 93);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(235, 23);
            txtAra.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 96);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "ARA";
            // 
            // lstYazar
            // 
            lstYazar.FormattingEnabled = true;
            lstYazar.ItemHeight = 15;
            lstYazar.Location = new Point(54, 128);
            lstYazar.Name = "lstYazar";
            lstYazar.Size = new Size(296, 184);
            lstYazar.TabIndex = 2;
            lstYazar.SelectedIndexChanged += lstYazar_SelectedIndexChanged;
            // 
            // lstKitap
            // 
            lstKitap.FormattingEnabled = true;
            lstKitap.ItemHeight = 15;
            lstKitap.Location = new Point(549, 128);
            lstKitap.Name = "lstKitap";
            lstKitap.Size = new Size(195, 184);
            lstKitap.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 110);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "KİTAPLAR";
            // 
            // button1
            // 
            button1.Location = new Point(345, 344);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(398, 141);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 171);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 123);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 7;
            label3.Text = "Yazar Hakkında";
            // 
            // AuthorDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lstKitap);
            Controls.Add(lstYazar);
            Controls.Add(label1);
            Controls.Add(txtAra);
            Name = "AuthorDetailsForm";
            Text = "AuthorDetailsForm";
            Load += AuthorDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAra;
        private Label label1;
        private ListBox lstYazar;
        private ListBox lstKitap;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
    }
}