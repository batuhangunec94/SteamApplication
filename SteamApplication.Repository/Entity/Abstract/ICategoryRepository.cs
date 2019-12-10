using SteamApplication.Model.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamApplication.Repository.Entity.Abstract
{
    public interface ICategoryRepository
    {
        void Add(string name, string description, string imgURL);
        void Update(int id, string name, string description, string imgURL);
        void Delete(int id);
        void TextBoxEraser(GroupBox groupBox);
        List<Category> TakeList();
        List<Category> GetAll();
        List<Category> FindByName(string name);
        List<Category> GetByDateTime(DateTime startedDate , DateTime endDate);
    }
}
