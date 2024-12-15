using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
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
    public partial class PublisherForm : Form
    {
        private readonly PublisherService _publisherService;

        public PublisherForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _publisherService = new PublisherService(new PublisherRepository(dbContext));
        }
        private void GetAllPublishers()
        {
            lstListe.DisplayMember = "Name";
            lstListe.ValueMember = "Id";
            lstListe.DataSource = _publisherService.GetAll();
            lstListe.SelectedIndex = -1;
            secilenYayinci = null;
            FormuTemizle();
        }
        private void FormuTemizle()
        {
            txtCountry.Text = "";
            hoveredIndex = -1;
            clickedIndex = -1;
            lstListe.Invalidate();
            txtName.Text = "";
            txtName.Focus();
        }
        private void PublisherForm_Load(object sender, EventArgs e)
        {
            GetAllPublishers();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_publisherService.IfEntityExists(a => a.Name == txtName.Text))
                {
                    throw new Exception("Bu yayın evi daha önce girilmiş");
                }
                Publisher newPublisher = new Publisher()
                {
                    Name = txtName.Text,
                    Country = txtCountry.Text
                };

                _publisherService.Create(newPublisher);
                MessageBox.Show("Kayıt Başarılı");
                GetAllPublishers();
                FormuTemizle();
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
                FormuTemizle();
            }
        }


        Publisher? secilenYayinci;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                secilenYayinci = (Publisher?)lstListe.SelectedItem;

                if (secilenYayinci != null)
                {
                    txtName.Text = secilenYayinci.Name;
                    txtCountry.Text = secilenYayinci.Country;
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_publisherService.IfEntityExists(a => a.Name == txtName.Text))
                {
                    secilenYayinci = (Publisher?)lstListe.SelectedItem;
                    txtName.Text = secilenYayinci?.Name;
                    throw new Exception("Bu yayın evi daha önce girilmiş");

                }

                if (secilenYayinci != null)
                {
                    secilenYayinci.Name = txtName.Text;
                    secilenYayinci.Country = txtCountry.Text;

                    _publisherService.Update(secilenYayinci);
                    MessageBox.Show("Güncelleme işlemi başarılı");
                    GetAllPublishers();
                }
                else
                {
                    MessageBox.Show("Lütfen bir yayın evi seçiniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstListe.SelectedIndex == -1)
                    throw new Exception("Listeden Kitap türü seçiniz.");

                if (secilenYayinci != null)
                {
                    _publisherService.Delete(secilenYayinci.Id);
                    GetAllPublishers();
                    MessageBox.Show("İşlem Başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int hoveredIndex = -1;   
        private int clickedIndex = -1;
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
                var item = lstListe.Items[e.Index] as Publisher;
                string text = item != null ? item.Name : "Bilinmeyen";
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
