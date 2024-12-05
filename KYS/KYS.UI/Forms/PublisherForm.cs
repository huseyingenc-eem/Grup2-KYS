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
    public partial class PublisherForm : BaseForm
    {
        private readonly PublisherService _publisherService;
        private readonly PublisherRepository _publisherRepository;

        public PublisherForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _publisherRepository = new PublisherRepository(dbContext);
            _publisherService = new PublisherService(_publisherRepository);
        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {
            GetAllPublishers();
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Publisher newPublisher = new Publisher()
                {
                    Name = txtName.Text,
                    Country = txtCountry.Text
                };

                if (_publisherService.IfEntityExists(a => a.Name == newPublisher.Name))
                {
                    throw new Exception("Bu yayın evi daha önce girilmiş");
                }
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

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
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

        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void FormuTemizle()
        {
            txtCountry.Text = "";
            txtName.Text = "";
            txtName.Focus();
        }

        Publisher? secilenYayinci;
        private void GetAllPublishers()
        {
            lstListe.DisplayMember = "Name";
            lstListe.ValueMember = "Id";
            lstListe.DataSource = _publisherService.GetAll();
            lstListe.SelectedIndex = -1;
            secilenYayinci = null;
            FormuTemizle();
        }

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
    }
}
