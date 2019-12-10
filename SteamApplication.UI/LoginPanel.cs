using SteamApplication.DAL.Context;
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
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }
        AppUserOfRepository service = new AppUserOfRepository();
        ProjectContext db = new ProjectContext();
        AppUser appUser = new AppUser();
        private void btnLogin_Click(object sender, EventArgs e)
        {

            foreach (var item in db.AppUsers)
            {
                if (txtUserName.Text == appUser.UserName || txtPassword.Text == appUser.Password)
                {

                    if (appUser.Role == Role.Admin && appUser.Role == Role.Moderator)
                    {
                        MessageBox.Show("İşlem Başarılı");
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Burası admin paneli sen kullanıcı panelinden giriş yapmalısın");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı yada şifre yanlış");
                }
            }
        }
    }
}
