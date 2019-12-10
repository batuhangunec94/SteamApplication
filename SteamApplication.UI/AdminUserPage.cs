using SteamApplication.Model.ORM.Concrete;
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
    public partial class AdminUserPage : Form
    {
        AppUserOfRepository service = new AppUserOfRepository();

        public AdminUserPage()
        {
            InitializeComponent();
        }

        private void AdminUserPage_Load(object sender, EventArgs e)
        {
            service.GetEnum(cmbAddRole,cmbUpdateRole);
            dataGridView1.DataSource =  service.TakeList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddFName.Text =="" || txtAddLName.Text == "" || txtAddEmail.Text == "" || txtAddUserName.Text == "" || txtAddPassword.Text == "")
            {
                MessageBox.Show("Ekleme işlemi boş geçilemez");
            }
            else
            {
                service.Add(txtAddFName.Text, txtAddLName.Text, txtAddUserName.Text, txtAddEmail.Text, txtAddPassword.Text, (Role)Enum.Parse(typeof(Role), cmbAddRole.Text));
                dataGridView1.DataSource = service.TakeList();
                service.TextBoxEraser(groupBox1);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUpdateFName.Text == "" || txtUpdateLName.Text == "" || txtUpdateEmail.Text == "" || txtUpdateUserName.Text == "" || txtUpdatePassword.Text == "")
            {
                MessageBox.Show("Update işlemi boş geçilemez");
            }
            else
            {
                service.Update(Convert.ToInt32(txtUpdateID.Text), txtUpdateFName.Text, txtUpdateLName.Text, txtUpdateUserName.Text, txtUpdateEmail.Text, txtUpdatePassword.Text, (Role)Enum.Parse(typeof(Role), cmbUpdateRole.Text));
                dataGridView1.DataSource = service.GetAll();
                service.TextBoxEraser(groupBox1);
            }
        }

        private void txtUpdateID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            txtUpdateID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtDelete.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtUpdateFName.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
            txtUpdateLName.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
            txtUpdateEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txtUpdateUserName.Text = dataGridView1.CurrentRow.Cells["UserName"].Value.ToString();
            txtUpdatePassword.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
            cmbUpdateRole.SelectedItem = dataGridView1.CurrentRow.Cells["Role"].Value.ToString();
            



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                service.Delete(Convert.ToInt32(txtDelete.Text));
                dataGridView1.DataSource = service.TakeList();
                service.TextBoxEraser(groupBox3);
            }
            catch (Exception)
            {
                MessageBox.Show("Delete işlemi boş geçilemez");
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = service.FindByName(txtFind.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Find işlemi için isim giriniz");
            }

        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetAll();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = service.GetByDateTime(Convert.ToDateTime(mskStartedDate.Text), Convert.ToDateTime(mskEndDate.Text));
                service.TextBoxEraser(groupBox6);
            }
            catch (Exception)
            {

                MessageBox.Show("iki adet tarih giriniz");
            }
        }

        private void cmbAddRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void cmbUpdateRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void txtDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
