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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is GroupBox)
                {
                    GroupBox gbox = (GroupBox)item;

                    foreach (var t in gbox.Controls)
                    {
                        if (t is TextBox)
                        {
                            TextBox a = t as TextBox;
                            a.Text = string.Empty;
                        }

                        if (t is PictureBox)
                        {
                            PictureBox pic = t as PictureBox;
                            pic.Image = null;
                        }

                        if (t is MaskedTextBox)
                        {
                            MaskedTextBox mbox = t as MaskedTextBox;
                            mbox.Clear();  // MaskedTextBox'ı temizliyoruz
                        }

                        if (t is DateTimePicker)
                        {
                            DateTimePicker dtp = t as DateTimePicker;
                            dtp.Value = DateTime.Now;
                        }

                        if (t is CheckBox)
                        {
                            CheckBox chk = t as CheckBox;
                            chk.Checked = false;
                        }

                        if (t is ComboBox)
                        {
                            ComboBox cmb = t as ComboBox;
                            if (cmb.Items.Count > 0)
                                cmb.SelectedIndex = 0;
                            else
                                cmb.SelectedIndex = -1;
                        }

                    }
                }

                if (item is TextBox)
                {
                    TextBox t = item as TextBox;
                    t.Text = string.Empty;
                }

                if (item is PictureBox)
                {
                    PictureBox pic = item as PictureBox;
                    pic.Image = null;
                }
                if (item is MaskedTextBox)
                {
                    MaskedTextBox mbox = item as MaskedTextBox;
                    mbox.Clear();  // MaskedTextBox'ı temizliyoruz
                }

                if (item is DateTimePicker)
                {
                    DateTimePicker dtp = item as DateTimePicker;
                    dtp.Value = DateTime.Now;
                }

                if (item is ComboBox)
                {
                    ComboBox cmb = item as ComboBox;
                    if (cmb.Items.Count > 0)
                        cmb.SelectedIndex = 0;
                    else
                        cmb.SelectedIndex = -1;
                }
            }
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
