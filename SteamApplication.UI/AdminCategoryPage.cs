using SteamApplication.Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamApplication.UI
{
    public partial class AdminCategoryPage : Form
    {
        CategoryOfRepository service = new CategoryOfRepository();
        public AdminCategoryPage()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            openFileDialogAdd.ShowDialog();
            txtImgAdd.Text = openFileDialogAdd.FileName;
            pctAdd.ImageLocation = openFileDialogAdd.FileName;
        }

        private void txtImgAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            if (txtNameAdd.Text ==""  && txtDescriptionAdd.Text == "" && txtImgAdd.Text == "")
            {
                MessageBox.Show("Ekleme işlemşi boş geçilemez");
            }
            else
            {
                service.Add(txtNameAdd.Text, txtDescriptionAdd.Text, txtImgAdd.Text);
                dataGridView1.DataSource = service.TakeList();
                service.TextBoxEraser(groupBox1);
            }
        }

        private void btnUpdateFile_Click(object sender, EventArgs e)
        {
            openFileDialogUpdate.ShowDialog();
            txtUpdateImg.Text = openFileDialogUpdate.FileName;
            pctImgUpdate.ImageLocation = openFileDialogUpdate.FileName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUpdateID.Text == "" && txtNameUpdate.Text == "" && txtUpdateDescripiton.Text == "" && txtUpdateImg.Text == "")
            {
                MessageBox.Show("Update işlemi Boş Geçilemez");
            }
            else
            {
                service.Update(Convert.ToInt32(txtUpdateID.Text), txtNameUpdate.Text, txtUpdateDescripiton.Text, txtUpdateImg.Text);
                dataGridView1.DataSource = service.GetAll();
                service.TextBoxEraser(groupBox2);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                service.Delete(Convert.ToInt32(txtDeleteID.Text));
                dataGridView1.DataSource = service.TakeList();
                service.TextBoxEraser(groupBox3);
            }
            catch (Exception)
            {

                MessageBox.Show("Silinicek ID mevcut değil");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = service.FindByName(txtFind.Text);
                service.TextBoxEraser(groupBox4);
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı İsim Girişi Yaptınız");
            }
            

        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetAll();
        }

        private void btnGetDate_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = service.GetByDateTime(Convert.ToDateTime(mskStartedDate.Text), Convert.ToDateTime(mskEndDate.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Geçerli 2 adres giriniz");
            }
        }

        private void AdminCategoryPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.TakeList();
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            txtUpdateID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtDeleteID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtNameUpdate.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtUpdateDescripiton.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            txtUpdateImg.Text = dataGridView1.CurrentRow.Cells["ImgURL"].Value.ToString();
            pctImgUpdate.ImageLocation = dataGridView1.CurrentRow.Cells["ImgURL"].Value.ToString();
        }

        private void txtDeleteID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUpdateID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void txtUpdateImg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }
    }
}
