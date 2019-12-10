using SteamApplication.Model.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamApplication.Repository.Entity.Abstract
{
    public interface IAppUserRepository
    {
        void Add(string firstName, string lastName, string userName, string email, string password, Role role);
        void Update(int id, string firstName, string lastName, string userName, string email, string password, Role role);
        void Delete(int id);
        void TextBoxEraser(GroupBox groupBox);
        List<AppUser> TakeList();
        List<AppUser> FindByName(string name);
        List<AppUser> GetAll();
        List<AppUser> GetByDateTime(DateTime startedDate, DateTime endDate);
        void GetEnum(ComboBox comboBoxAdd, ComboBox comboBoxUpdate);
        
    }
}
