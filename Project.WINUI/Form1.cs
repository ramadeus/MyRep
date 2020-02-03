using Project.BLL.DesignPatterns.GenericRepositoryPattern.ConcRep;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WINUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            arep = new AppUserRep();
        }
        AppUserRep arep;
        AppUser modify;
        public void Listele()
        {
            dgvSonuc.DataSource = arep.GetAll();
            txtBox1.Text = txtBox2.Text = string.Empty;
            dgvSonuc.ClearSelection();
        }
        public bool TextControl()
        {
            if (txtBox1.Text==string.Empty|| txtBox2.Text == string.Empty)
            {
                MessageBox.Show("Lütfen alanları boş bırakmayınız.");
                return false;
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnActives_Click(object sender, EventArgs e)
        {
            dgvSonuc.DataSource = arep.GetActives();
        }

        private void btnPassives_Click(object sender, EventArgs e)
        {
            dgvSonuc.DataSource = arep.GetPassives();
        }

        private void btnUpdateds_Click(object sender, EventArgs e)
        {
            dgvSonuc.DataSource = arep.GetUpdateds();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!TextControl()) return;
            arep.Add(new AppUser(txtBox1.Text, txtBox2.Text));
            Listele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!TextControl()) return;
            if (modify is null)
            {
                MessageBox.Show("Lütfen silinecek veriyi seçiniz.");
                return;
            }

            arep.Delete(modify); modify = null;
            Listele();

        }

        private void dgvSonuc_Click(object sender, EventArgs e)
        {
            if (dgvSonuc.SelectedRows.Count>0)
            {
                int id = Convert.ToInt32(dgvSonuc.SelectedRows[0].Cells["ID"].Value);
                modify = arep.Find(id);
                txtBox1.Text = modify.UserName;
                txtBox2.Text = modify.Password;
            }
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            if (!TextControl()) return;
            if (modify is null)
            {
                MessageBox.Show("Lütfen kaldırılacak veriyi seçiniz.");
                return;
            }

          
            arep.Remove(modify);  modify = null;
            Listele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!TextControl()) return;
            if (modify is null)
            {
                MessageBox.Show("Lütfen güncellenecek veriyi seçiniz.");
                return;
            }
            modify.UserName = txtBox1.Text;
            modify.Password = txtBox2.Text;
            arep.Update(modify);
            modify = null;
            Listele();
        }
    }
}
