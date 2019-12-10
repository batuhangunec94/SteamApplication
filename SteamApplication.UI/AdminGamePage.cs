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
    public partial class AdminGamePage : Form
    {
        GameOfRepository service = new GameOfRepository();
        public AdminGamePage()
        {
            InitializeComponent();
        }

        private void AdminGamePage_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = service.TakeCategoryList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;

            cmbUser.DataSource = service.TakeAppUserList();
            cmbUser.DisplayMember = "FirstName";
            cmbUser.ValueMember = "ID";
            cmbUser.SelectedIndex = -1;

            cmbUpdateCategory.DataSource = service.TakeCategoryList();
            cmbUpdateCategory.DisplayMember = "Name";
            cmbUpdateCategory.ValueMember = "ID";
            cmbUpdateCategory.SelectedIndex = -1;

            cmbUpdateUser.DataSource = service.TakeAppUserList();
            cmbUpdateUser.DisplayMember = "FirstName";
            cmbUpdateUser.ValueMember = "ID";
            cmbUpdateUser.SelectedIndex = -1;

            dataGridView1.DataSource = service.TakeList();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            openFileDialogAdd.ShowDialog();
            txtAddImg.Text = openFileDialogAdd.FileName;
            pctAddImg.ImageLocation = openFileDialogAdd.FileName;
        }

        private void txtAddImg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddName.Text == "" || txtAddImg.Text == "" || txtAddDescription.Text == "" || cmbCategory.Text == "" || cmbUser.Text == "")
            {
                MessageBox.Show("Add işlemi boş geçilemez");
            }
            else
            {
                service.Add(txtAddName.Text,txtAddDescription.Text,txtAddImg.Text,(int)(cmbCategory.SelectedValue),(int)(cmbUser.SelectedValue));
                dataGridView1.DataSource = service.TakeList();
                service.TextBoxEraser(groupBox1);

            }
        }

        private void btnUpdateFile_Click(object sender, EventArgs e)
        {
            openFileDialogUpdate.ShowDialog();
            txtUpdateImg.Text = openFileDialogUpdate.FileName;
            pctUpdateImg.ImageLocation = openFileDialogUpdate.FileName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUpdateName.Text == "" || txtUpdateImg.Text == "" || txtUpdateDescription.Text == "" || txtUpdateID.Text == "")
                {
                    MessageBox.Show("Update işlemi boş geçilemez");
                }
                else
                {
                    service.Update(Convert.ToInt32(txtUpdateID.Text), txtUpdateName.Text, txtUpdateDescription.Text, txtUpdateImg.Text, (int)(cmbUpdateCategory.SelectedValue), (int)(cmbUpdateUser.SelectedValue));
                    dataGridView1.DataSource = service.TakeList();
                    service.TextBoxEraser(groupBox2);
                    service.TextBoxEraser(groupBox3);
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Update işlemi boş geçilemez");
            }
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            txtUpdateID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtDeleteID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtUpdateName.Text = dataGridView1.CurrentRow.Cells["GameName"].Value.ToString();
            txtUpdateDescription.Text = dataGridView1.CurrentRow.Cells["GameDescription"].Value.ToString();
            txtUpdateImg.Text = dataGridView1.CurrentRow.Cells["GameImgURL"].Value.ToString();
            pctUpdateImg.ImageLocation = dataGridView1.CurrentRow.Cells["GameImgURL"].Value.ToString();
            cmbCategory.SelectedItem=int.Parse(dataGridView1.CurrentRow.Cells["CategoryID"].Value.ToString());
            cmbUpdateUser.SelectedItem = int.Parse(dataGridView1.CurrentRow.Cells["AppUserID"].Value.ToString());
        }

        private void btnDeleteID_Click(object sender, EventArgs e)
        {
            try
            {
                service.Delete(Convert.ToInt32(txtDeleteID.Text));
                dataGridView1.DataSource = service.TakeList();
                service.TextBoxEraser(groupBox3);
                service.TextBoxEraser(groupBox2);
            }
            catch (Exception)
            {

                MessageBox.Show("Delete işlemi boş geçilemez");
            }
        }

        

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetAll();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFindName.Text != "")
            {
                dataGridView1.DataSource = service.FindByName(txtFindName.Text);
                service.TextBoxEraser(groupBox5);
            }
            else
            {
                MessageBox.Show("Bulabilmem için oyun ismi girmelisin");
            }
        }

        private void btnGetDAte_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = service.GetByDateTime(Convert.ToDateTime(mskStartedDate.Text), Convert.ToDateTime(mskEndDate.Text));
                service.TextBoxEraser(groupBox6);
            }
            catch (Exception)
            {

                MessageBox.Show("İki adet geçerli tarih giriniz");
            }
        }

        private void txtUpdateID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void txtUpdateImg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void cmbCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void cmbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void cmbUpdateCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void cmbUpdateUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void txtDeleteID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
