using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;

namespace KYS.UI.Forms
{
    public partial class AnnouncementForm : Form
    {
        private readonly DuyurularService _duyuruService;
        private readonly DuyurularRepository _duyurularRepository;
        public AnnouncementForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _duyurularRepository = new DuyurularRepository(dbContext);
            _duyuruService = new DuyurularService(_duyurularRepository);
        }

        private void AnnouncementForm_Load(object sender, EventArgs e)
        {
            GetAllDuyurular();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Duyurular newDuyurular = new Duyurular()
                {
                    Baslik = txtTitle.Text,
                    Icerik = txtDescription.Text,
                    DuyuruTarihi = dtpDate.Value
                };

                if (_duyuruService.IfEntityExists(a => a.Baslik == newDuyurular.Baslik))
                {
                    throw new Exception("Bu duyuru daha önce girilmiş");
                }
                _duyuruService.Create(newDuyurular);
                MessageBox.Show("Kayıt Başarılı");
                GetAllDuyurular();
                FormuTemizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        Duyurular? secilenDuyuru;
        private void GetAllDuyurular()
        {
            lstListe.DisplayMember = "Baslik";
            lstListe.ValueMember = "Id";
            lstListe.DataSource = _duyuruService.GetAll();
            lstListe.SelectedIndex = -1;
            secilenDuyuru = null;
            FormuTemizle();
        }

        private int hoveredIndex = -1;
        private int clickedIndex = -1;
        private void FormuTemizle()
        {
            txtDescription.Text = "";
            dtpDate.Value = DateTime.Now;
            hoveredIndex = -1;
            clickedIndex = -1;
            lstListe.Invalidate(); // Renk değişikliklerini sıfırla
            txtTitle.Text = "";
            txtTitle.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenDuyuru != null)
                {
                    _duyuruService.Delete(secilenDuyuru.Id);
                    GetAllDuyurular();
                    MessageBox.Show("İşlem Başarılı");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenDuyuru != null)
                {
                    secilenDuyuru.Baslik = txtTitle.Text;
                    secilenDuyuru.Icerik = txtDescription.Text;
                    secilenDuyuru.DuyuruTarihi = dtpDate.Value;

                    _duyuruService.Update(secilenDuyuru);
                    MessageBox.Show("Güncelleme işlemi başarılı");
                    GetAllDuyurular();
                }
                else
                {
                    MessageBox.Show("Lütfen bir duyuru seçiniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (this.GetChildAtPoint(e.Location) == null)
            {
                FormuTemizle(); // Sadece boş alana tıklanırsa çalışır
            }
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                secilenDuyuru = (Duyurular?)lstListe.SelectedItem;

                if (secilenDuyuru != null)
                {
                    txtTitle.Text = secilenDuyuru.Baslik;
                    txtDescription.Text = secilenDuyuru.Icerik;
                    dtpDate.Value = secilenDuyuru.DuyuruTarihi;
                }
            }
        }

        private void lstListe_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Color backColor = Color.White;
            Color textColor = Color.Black;

            if (e.Index == hoveredIndex)
                backColor = Color.LightSteelBlue;

            if (e.Index == clickedIndex)
                backColor = Color.LightBlue;

            e.DrawBackground();
            using (Brush brush = new SolidBrush(backColor))
                e.Graphics.FillRectangle(brush, e.Bounds);

            using (Brush textBrush = new SolidBrush(textColor))
            {
                var item = lstListe.Items[e.Index] as Duyurular;
                string text = item != null ? item.Baslik : "Bilinmeyen";
                e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds);
            }

            e.DrawFocusRectangle();


        }

        private void lstListe_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lstListe.IndexFromPoint(e.Location);
            if (index != hoveredIndex)
            {
                hoveredIndex = index;
                lstListe.Invalidate();
            }
        }

        private void lstListe_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lstListe.IndexFromPoint(e.Location);
            if (index >= 0)
            {
                clickedIndex = index;
                lstListe.Invalidate();
            }
        }
    }
}
