using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using KYS.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYS.UI.Forms
{
    public partial class BookTypeForm : Form
    {
        private readonly BookTypeService _bookTypeService;

        public BookTypeForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _bookTypeService = new BookTypeService(new BookTypeRepository(dbContext));
        }
        private void GetAllBookType()
        {
            lstType.ValueMember = "Id";
            lstType.DisplayMember = "Name";
            lstType.DataSource = _bookTypeService.GetAll().ToList();
            lstType.SelectedIndex = -1;
            FormuTemizle();
        }
        private void FormuTemizle()
        {
            txtName.Clear();
            txtDescription.Clear();
            hoveredIndex = -1;
            clickedIndex = -1;
            lstType.Invalidate();
            txtName.Focus();
        }
        private void BookTypeForm_Load(object sender, EventArgs e)
        {

            lblWelcome.Text = $"Hoş geldiniz, {SessionManager.CurrentUser?.Name}";
            GetAllBookType();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bookTypeService.IfEntityExists(x => x.Name == txtName.Text))
                    throw new Exception($"{txtName.Text} bu Kitap türü zaten var.");

                BookType newBookType = new BookType()
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text
                };

                _bookTypeService.Create(newBookType);
                MessageBox.Show("Kitap türü Eklendi.");
                GetAllBookType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        BookType? selectedBookType;
        private void lstType_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedBookType = (BookType?)lstType.SelectedItem;

            if (selectedBookType != null)
            {
                txtName.Text = selectedBookType.Name;
                txtDescription.Text = selectedBookType.Description;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstType.SelectedIndex == -1)
                    throw new Exception("Listeden Kitap türü seçiniz.");

                if (_bookTypeService
                    .IfEntityExists(x => x.Name == txtName.Text))
                {
                    selectedBookType = (BookType?)lstType.SelectedItem;
                    txtName.Text = selectedBookType?.Name;
                    throw new Exception($"{txtName.Text} bu Kitap türü zaten var.");

                }

                if (selectedBookType != null)
                {
                    selectedBookType.Name = txtName.Text;
                    selectedBookType.Description = txtDescription.Text;
                }
                _bookTypeService.Update(selectedBookType);
                MessageBox.Show("Güncelleme İşlemi Başarılı.");
                GetAllBookType();
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstType.SelectedIndex == -1)
                    throw new Exception("Listeden Kitap türü seçiniz.");
                if (selectedBookType != null)
                    _bookTypeService.Delete(selectedBookType.Id);

                GetAllBookType();
                MessageBox.Show("Silme İşlemi Başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int hoveredIndex = -1;
        private int clickedIndex = -1;

        private void lstType_DrawItem(object sender, DrawItemEventArgs e)
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
                var item = lstType.Items[e.Index] as BookType;
                string text = item != null ? item.Name : "Bilinmeyen";
                e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void lstType_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lstType.IndexFromPoint(e.Location);
            if (index != hoveredIndex)
            {
                hoveredIndex = index;
                lstType.Invalidate();
            }
        }

        private void lstType_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lstType.IndexFromPoint(e.Location);
            if (index >= 0)
            {
                clickedIndex = index;
                lstType.Invalidate();
            }
        }
    }
}
