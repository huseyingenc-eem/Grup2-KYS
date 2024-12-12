using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using System.Runtime.InteropServices.JavaScript;

namespace KYS.UI.Forms
{
    public partial class Authorform : BaseForm
    {
        private readonly AuthorService _authorService;
        public Authorform()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _authorService = new AuthorService(new AuthorRepository(dbContext));

            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void Authorform_Load(object sender, EventArgs e)
        {
            GetAllAuthor();
        }
        private void GetAllAuthor()
        {
            lstListe.DisplayMember = "FullName";
            lstListe.ValueMember = "Id";
            lstListe.DataSource = _authorService.GetAll();
            lstListe.SelectedIndex = -1;
            secilenYazar = null;
            FormuTemizle();
        }
        private void FormuTemizle()
        {
            txtSurname.Text = "";
            txtCountry.Text = "";
            txtBiography.Text = "";
            txtBirthDate.Text = "";
            txtDeathDate.Text = "";
            pictureBoxPhoto.ImageLocation = null;
            txtName.Text = "";
            txtName.Focus();
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Author newAuthor = new Author()
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    Country = txtCountry.Text,
                    BirthDate = Convert.ToDateTime(txtBirthDate.Text),
                    DeathDate = Convert.ToDateTime(txtDeathDate.Text),
                    Biography = txtBiography.Text,
                    PhotoUrl = pictureBoxPhoto.ImageLocation
                };

                if (_authorService.IfEntityExists(a => a.PhotoUrl == newAuthor.PhotoUrl))
                {
                    throw new Exception("Eklemeye çalıştığınız yazar zaten kaydedilmiştir.");
                }
                _authorService.Create(newAuthor);
                MessageBox.Show("Kayıt Başarılı");
                GetAllAuthor();
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Author? secilenYazar;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                secilenYazar = (Author?)lstListe.SelectedItem;

                if (secilenYazar != null)
                {
                    txtName.Text = secilenYazar.Name;
                    txtSurname.Text = secilenYazar.Surname;
                    txtCountry.Text = secilenYazar.Country;
                    txtBiography.Text = secilenYazar.Biography;
                    txtBirthDate.Text = secilenYazar.BirthDate.HasValue
                        ? secilenYazar.BirthDate.Value.ToString("dd/MM/yyyy")
                        : string.Empty;
                    txtDeathDate.Text = secilenYazar.DeathDate.HasValue
                        ? secilenYazar.DeathDate.Value.ToString("dd/MM/yyyy")
                        : string.Empty;
                    pictureBoxPhoto.ImageLocation = secilenYazar.PhotoUrl;
                }
            }
        }
        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstListe.SelectedIndex == -1)
                    throw new Exception("Listeden Kitap türü seçiniz.");

                if (_authorService
                    .IfEntityExists(x => x.PhotoUrl == pictureBoxPhoto.ImageLocation))
                {
                    secilenYazar = (Author?)lstListe.SelectedItem;
                    txtName.Text = secilenYazar?.Name;
                    pictureBoxPhoto.ImageLocation =secilenYazar?.PhotoUrl;
                    throw new Exception("Güncellemeye çalıştığınız yazar zaten kaydedilmiştir.");

                }
                if (secilenYazar != null)
                {
                    secilenYazar.Name = txtName.Text;
                    secilenYazar.Surname = txtSurname.Text;
                    secilenYazar.Country = txtCountry.Text;
                    secilenYazar.Biography = txtBiography.Text;
                    secilenYazar.BirthDate = Convert.ToDateTime(txtBirthDate.Text);
                    secilenYazar.DeathDate = Convert.ToDateTime(txtDeathDate.Text);
                    secilenYazar.PhotoUrl = pictureBoxPhoto.ImageLocation;

                    _authorService.Update(secilenYazar);
                    MessageBox.Show("Güncelleme işlemi başarılı");
                    GetAllAuthor();
                }
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
                if (lstListe.SelectedIndex == -1)
                    throw new Exception("Listeden Yazar seçiniz.");

                if (secilenYazar != null)
                {
                    _authorService.Delete(secilenYazar.Id);
                    GetAllAuthor();
                    MessageBox.Show("İşlem Başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = " Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Fotoğraf Seç";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPhoto.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        

        
    }
}
