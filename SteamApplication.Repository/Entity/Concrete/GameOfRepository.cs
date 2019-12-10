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
    public class GameOfRepository : BaseRepository, IGameRepository
    {
        Game game = new Game();
        public void Add(string gameName, string gameDescription, string gameImgURL, int categoryID, int appUserID)
        {
            game.GameName = gameName;
            game.GameDescription = gameDescription;
            game.GameImgURL = gameImgURL;
            game.CategoryID = categoryID;
            game.AppUserID = appUserID;
            db.Games.Add(game);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            game = db.Games.FirstOrDefault(x => x.ID == id);
            game.Delete = DateTime.Now;
            game.Status = Status.Passive;
            db.SaveChanges();
        }

        public List<Game> FindByName(string gameName)
        {
            return db.Games.Where(x => x.GameName == gameName).ToList();
        }

        public List<Game> GetAll()
        {
            return db.Games.ToList();
        }

        public List<Game> GetByDateTime(DateTime startedDate, DateTime endDate)
        {
            return db.Games.Where(x => x.AddDate >= startedDate && x.AddDate <= endDate).ToList();
        }

        public List<AppUser> TakeAppUserList()
        {
            return db.AppUsers.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();
        }

        public List<Category> TakeCategoryList()
        {
            return db.Categories.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();
        }

        public List<Game> TakeList()
        {
            return db.Games.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();
        }

        public void TextBoxEraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }

            }
        }

        public void Update(int id, string gameName, string gameDescription, string gameImgURL, int categoryID, int appUserID)
        {
            game = db.Games.FirstOrDefault(x => x.ID == id);
            game.GameName = gameName;
            game.GameDescription = gameDescription;
            game.GameImgURL = gameImgURL;
            game.CategoryID = categoryID;
            game.AppUserID = appUserID;
            game.Status = Status.Update;
            game.UpdateDate = DateTime.Now;
            db.SaveChanges();
        }
    }
}
