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
    public class CategoryOfRepository : BaseRepository, ICategoryRepository
    {
        Category category = new Category();
        public void Add(string name, string description, string imgURL)
        {

            category.Name = name;
            category.Description = description;
            category.ImgURL = imgURL;
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            try
            {
                category = db.Categories.FirstOrDefault(x => x.ID == id);
                category.Delete = DateTime.Now;
                category.Status = Status.Passive;
                db.SaveChanges();

            }
            catch (Exception)
            {

                MessageBox.Show("Delete işlemi için id giriniz");
            }
        }

        public List<Category> FindByName(string name)
        {
            return db.Categories.Where(x => x.Name == name).ToList();
            
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public List<Category> GetByDateTime(DateTime startedDate, DateTime endDate)
        {
            return db.Categories.Where(x => x.AddDate >= startedDate && x.AddDate <= endDate).ToList();
           
        }

        public List<Category> TakeList()
        {
            return db.Categories.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();
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

        public void Update(int id, string name, string description, string imgURL)
        {
            try
            {
                category = db.Categories.FirstOrDefault(x => x.ID == id);
                category.Name = name;
                category.Description = description;
                category.ImgURL = imgURL;
                category.Status = Status.Update;
                category.UpdateDate = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Update işlemi için boş alanları doldurunuz");
            }
            


        }
    }
}
