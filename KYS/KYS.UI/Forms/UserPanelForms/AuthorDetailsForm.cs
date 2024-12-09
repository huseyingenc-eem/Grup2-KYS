﻿using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
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
    public partial class AuthorDetailsForm : Form
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly AuthorService _autorService;
        private readonly BookService _bookService;
        public AuthorDetailsForm()
        {
            InitializeComponent();

            _dbContext = new ApplicationDBContext();
            AuthorRepository authorrepository = new AuthorRepository(_dbContext);
            BookRepository bookRepository = new BookRepository(_dbContext);

            _autorService = new AuthorService(authorrepository);
            _bookService = new BookService(bookRepository);
        }

        private void AuthorDetailsForm_Load(object sender, EventArgs e)
        {
            GetAllAuthorBySearchText(string.Empty);

        }
        Author? secilenYazar;
        private void GetAllAuthorBySearchText(string searchText)
        {
            if (!string.IsNullOrEmpty(searchText.ToLower()) && searchText.Length >= 3)
            {
                //yazarları filtreye göre fetirelim
                var authorList = _autorService.GetAll().Where(a => a.FullName.ToLower().Contains(searchText.ToLower()));

                lstYazar.ValueMember = "Id";
                lstYazar.DisplayMember = "FullName";
                lstYazar.DataSource = authorList.ToList();
            }
        }

        private void lstYazar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lstYazar.SelectedIndex != -1)
            {
                secilenYazar = (Author?)lstYazar.SelectedItem;
                if (secilenYazar != null)
                {
                    textBox1.Text= $"Ad : {secilenYazar.FullName}\r\n Doğum Tarihi : {secilenYazar.BirthDate}\r\n Ülke : {secilenYazar.Country}";

                    lstKitap.DisplayMember = "Name";
                    lstKitap.ValueMember = "Id";
                    lstKitap.DataSource = _bookService.GetAll();
                }

            }
            


        } 
       
    }
}
