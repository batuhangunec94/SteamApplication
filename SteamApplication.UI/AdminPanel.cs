using SteamApplication.DAL.Context;
using SteamApplication.Model.ORM.Abstract;
using SteamApplication.Model.ORM.Concrete;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        Game game = new Game();
        private void AdminPanel_Load(object sender, EventArgs e)
        {

            flowLayoutPanel1.AutoScroll = true;
            List<Game> games = db.Games.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();

            foreach (var item in games)
            {
                GroupBox grp = new GroupBox();

                grp.Location = new System.Drawing.Point(30, 120);
                grp.Size = new System.Drawing.Size(300, 420);
                PictureBox pctBox = new PictureBox();
                pctBox.Location = new System.Drawing.Point(5, 45);
                pctBox.Size = new System.Drawing.Size(290, 300);
                pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pctBox.Image = new Bitmap(item.GameImgURL);
                Label gameName = new Label();
                gameName.ForeColor = Color.DarkOrange;
                gameName.Text = item.GameName;
                gameName.Location = new System.Drawing.Point(5, 20);
                gameName.Size = new System.Drawing.Size(290, 20);
                Label gameDescription = new Label();
                gameDescription.ForeColor = Color.DarkOrange;
                gameDescription.Text = item.GameDescription;
                gameDescription.Location = new System.Drawing.Point(5,360);
                gameDescription.Size = new System.Drawing.Size(290, 50);
                grp.Controls.Add(gameName);
                grp.Controls.Add(gameDescription);
                grp.Controls.Add(pctBox);

                flowLayoutPanel1.Controls.Add(grp);
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            AdminCategoryPage adminCategoryPage = new AdminCategoryPage();
            adminCategoryPage.ShowDialog();
        }

        private void btnEditGame_Click(object sender, EventArgs e)
        {
            AdminGamePage adminGamePage = new AdminGamePage();
            adminGamePage.ShowDialog();
        }

        private void btnEditAppUser_Click(object sender, EventArgs e)
        {
            AdminUserPage adminUserPage = new AdminUserPage();
            adminUserPage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
