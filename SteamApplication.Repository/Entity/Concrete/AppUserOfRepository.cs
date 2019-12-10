using SteamApplication.Model.ORM.Abstract;
using SteamApplication.Model.ORM.Concrete;
using SteamApplication.Repository.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamApplication.Repository.Entity.Concrete
{
    public class AppUserOfRepository : BaseRepository, IAppUserRepository
    {
        AppUser appUser = new AppUser();
        public void Add(string firstName, string lastName, string userName, string email, string password, Role role)
        {
            appUser.FirstName = firstName;
            appUser.LastName = lastName;
            appUser.UserName = userName;
            appUser.Email = email;
            appUser.Password = password;
            appUser.Role = role;
            db.AppUsers.Add(appUser);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            appUser = db.AppUsers.FirstOrDefault(x => x.ID == id);
            appUser.Delete = DateTime.Now;
            appUser.Status = Status.Passive;
            db.SaveChanges();


        }

        public List<AppUser> FindByName(string name)
        {
            return db.AppUsers.Where(x => x.FirstName == name).ToList();
        }

        public List<AppUser> GetAll()
        {
            return db.AppUsers.ToList();
        }

        public List<AppUser> GetByDateTime(DateTime startedDate, DateTime endDate)
        {
            return db.AppUsers.Where(x => x.AddDate >= startedDate && x.AddDate  <= endDate).ToList();
        }

        public void GetEnum(ComboBox comboBoxAdd, ComboBox comboBoxUpdate)
        {
            comboBoxAdd.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxAdd.SelectedIndex = 0;

            comboBoxUpdate.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxUpdate.SelectedIndex = 0;
        }

        

        public List<AppUser> TakeList()
        {
            return db.AppUsers.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();
        }

        public void TextBoxEraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public void Update(int id, string firstName, string lastName, string userName, string email, string password, Role role)
        {
            appUser = db.AppUsers.FirstOrDefault(x => x.ID == id);
            appUser.FirstName = firstName;
            appUser.LastName = lastName;
            appUser.UserName = userName;
            appUser.Email = email;
            appUser.Password = password;
            appUser.Role = role;
            appUser.UpdateDate = DateTime.Now;
            appUser.Status = Status.Update;
            db.SaveChanges();
        }
    }
}
