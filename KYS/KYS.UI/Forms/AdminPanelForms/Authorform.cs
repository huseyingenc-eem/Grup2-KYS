using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using System.Runtime.InteropServices.JavaScript;

namespace KYS.UI.Forms
{
    public partial class Authorform : Form
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
            hoveredIndex = -1;
            clickedIndex = -1;
            lstListe.Invalidate();
            txtName.Text = "";
            txtName.Focus();
        }
        private void btnEkle_Click(object sender, EventArgs e)
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
        private void btnGuncelle_Click(object sender, EventArgs e)
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
                    pictureBoxPhoto.ImageLocation = secilenYazar?.PhotoUrl;
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

        private void btnSil_Click(object sender, EventArgs e)
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

        private int hoveredIndex = -1;
        private int clickedIndex = -1;

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (this.GetChildAtPoint(e.Location) == null)
            {
                FormuTemizle(); // Sadece boş alana tıklanırsa çalışır
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
                var item = lstListe.Items[e.Index] as Author;
                string text = item != null ? item.FullName : "Bilinmeyen";
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

        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Fotoğraf Seç";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Proje klasöründe 'Resources/Images' dizinini oluştur
                    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory; // Çalışma dizini
                    string imageFolderPath = Path.Combine(projectDirectory, "Resources", "Images");

                    if (!Directory.Exists(imageFolderPath))
                    {
                        Directory.CreateDirectory(imageFolderPath); // Klasör yoksa oluştur
                    }

                    // Seçilen resmin yeni yolunu belirle
                    string newImagePath = Path.Combine(imageFolderPath, Path.GetFileName(openFileDialog.FileName));

                    // Resmi hedef klasöre kopyala
                    File.Copy(openFileDialog.FileName, newImagePath, true);

                    // PictureBox'ta yeni resmi göster
                    pictureBoxPhoto.ImageLocation = newImagePath;

                    MessageBox.Show($"Resim başarıyla eklendi: {newImagePath}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pictureBoxPhoto_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBoxPhoto.Image == null) // Eğer resim yoksa yazı göster
            {
                string text = "Resim eklemek için tıklayınız";
                Font font = new Font("Arial", 10, FontStyle.Bold);
                SizeF textSize = e.Graphics.MeasureString(text, font);

                // Yazıyı PictureBox'ın ortasına hizala
                float x = (pictureBoxPhoto.Width - textSize.Width) / 2;
                float y = (pictureBoxPhoto.Height - textSize.Height) / 2;

                e.Graphics.DrawString(text, font, Brushes.Gray, x, y);
            }
        }
    }
}
