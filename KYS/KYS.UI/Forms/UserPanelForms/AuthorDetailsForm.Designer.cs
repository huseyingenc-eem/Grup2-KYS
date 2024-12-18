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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorDetailsForm));
            txtAra = new TextBox();
            label1 = new Label();
            lstYazar = new ListBox();
            lstKitap = new ListBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnSendToBook = new Button();
            lblUlke = new Label();
            lblBiografy = new Label();
            lblDogumTarih = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblFullName = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAra
            // 
            txtAra.Location = new Point(88, 75);
            txtAra.Margin = new Padding(6);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(249, 34);
            txtAra.TabIndex = 0;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(15, 81);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 1;
            label1.Text = "Ara      ";
            // 
            // lstYazar
            // 
            lstYazar.DrawMode = DrawMode.OwnerDrawFixed;
            lstYazar.FormattingEnabled = true;
            lstYazar.ItemHeight = 28;
            lstYazar.Location = new Point(26, 131);
            lstYazar.Margin = new Padding(6);
            lstYazar.Name = "lstYazar";
            lstYazar.Size = new Size(311, 564);
            lstYazar.TabIndex = 2;
            lstYazar.MouseClick += lstYazar_MouseClick;
            lstYazar.DrawItem += lstYazar_DrawItem;
            lstYazar.SelectedIndexChanged += lstYazar_SelectedIndexChanged;
            lstYazar.MouseMove += lstYazar_MouseMove;
            // 
            // lstKitap
            // 
            lstKitap.DrawMode = DrawMode.OwnerDrawFixed;
            lstKitap.FormattingEnabled = true;
            lstKitap.ItemHeight = 28;
            lstKitap.Location = new Point(12, 387);
            lstKitap.Margin = new Padding(6);
            lstKitap.Name = "lstKitap";
            lstKitap.Size = new Size(482, 200);
            lstKitap.TabIndex = 3;
            lstKitap.MouseClick += lstKitap_MouseClick;
            lstKitap.DrawItem += lstKitap_DrawItem;
            lstKitap.SelectedIndexChanged += lstKitap_SelectedIndexChanged;
            lstKitap.MouseMove += lstKitap_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 353);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 4;
            label2.Text = "Yazarın Kitapları";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSendToBook);
            groupBox1.Controls.Add(lblUlke);
            groupBox1.Controls.Add(lblBiografy);
            groupBox1.Controls.Add(lblDogumTarih);
            groupBox1.Controls.Add(lstKitap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblFullName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(349, 25);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(515, 670);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yazar Hakkında";
            // 
            // btnSendToBook
            // 
            btnSendToBook.Location = new Point(49, 603);
            btnSendToBook.Margin = new Padding(6);
            btnSendToBook.Name = "btnSendToBook";
            btnSendToBook.Size = new Size(445, 43);
            btnSendToBook.TabIndex = 9;
            btnSendToBook.Text = "Kitap Detayı Hakkında Bilgi Almak içinTıklayınız";
            btnSendToBook.UseVisualStyleBackColor = true;
            btnSendToBook.Click += btnSendToBook_Click;
            // 
            // lblUlke
            // 
            lblUlke.BorderStyle = BorderStyle.FixedSingle;
            lblUlke.Font = new Font("Segoe UI", 15F);
            lblUlke.Location = new Point(314, 166);
            lblUlke.Margin = new Padding(6, 0, 6, 0);
            lblUlke.Name = "lblUlke";
            lblUlke.Size = new Size(180, 30);
            lblUlke.TabIndex = 8;
            // 
            // lblBiografy
            // 
            lblBiografy.AutoEllipsis = true;
            lblBiografy.BorderStyle = BorderStyle.FixedSingle;
            lblBiografy.Font = new Font("Segoe UI", 10F);
            lblBiografy.Location = new Point(270, 211);
            lblBiografy.Margin = new Padding(6, 0, 6, 0);
            lblBiografy.Name = "lblBiografy";
            lblBiografy.Size = new Size(224, 166);
            lblBiografy.TabIndex = 7;
            // 
            // lblDogumTarih
            // 
            lblDogumTarih.BackColor = SystemColors.Control;
            lblDogumTarih.BorderStyle = BorderStyle.FixedSingle;
            lblDogumTarih.Font = new Font("Segoe UI", 15F);
            lblDogumTarih.Location = new Point(314, 121);
            lblDogumTarih.Margin = new Padding(6, 0, 6, 0);
            lblDogumTarih.Name = "lblDogumTarih";
            lblDogumTarih.Size = new Size(180, 30);
            lblDogumTarih.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(176, 166);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 28);
            label6.TabIndex = 5;
            label6.Text = "Ülke:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 213);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 5;
            label5.Text = "Biyografi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 121);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 28);
            label4.TabIndex = 5;
            label4.Text = "Doğum Tarihi:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(248, 50);
            lblFullName.Margin = new Padding(6, 0, 6, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.RightToLeft = RightToLeft.No;
            lblFullName.Size = new Size(0, 28);
            lblFullName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 50);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 1;
            label3.Text = "Yazar Adı: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(9, 112);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AuthorDetailsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(887, 713);
            Controls.Add(groupBox1);
            Controls.Add(lstYazar);
            Controls.Add(label1);
            Controls.Add(txtAra);
            Font = new Font("Segoe UI", 15F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "AuthorDetailsForm";
            Text = "AuthorDetailsForm";
            Load += AuthorDetailsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAra;
        private Label label1;
        private ListBox lstYazar;
        private ListBox lstKitap;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblFullName;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label lblBiografy;
        private Label lblDogumTarih;
        private Label label6;
        private Label lblUlke;
        private Button btnSendToBook;
        private PictureBox pictureBox1;
    }
}