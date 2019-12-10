using SteamApplication.Model.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamApplication.Repository.Entity.Abstract
{
    public interface IGameRepository
    {
        void Add(string gameName, string gameDescription, string gameImgURL, int categoryID, int appUserID);
        void Update(int id, string gameName, string gameDescription, string gameImgURL, int categoryID, int appUserID);
        void Delete(int id);
        void TextBoxEraser(GroupBox groupBox);
        List<Game> TakeList();
        List<Game> FindByName(string gameName);
        List<Game> GetAll();
        List<Game> GetByDateTime(DateTime startedDate, DateTime endDate);

        List<Category> TakeCategoryList();
        List<AppUser> TakeAppUserList();



    }
}
