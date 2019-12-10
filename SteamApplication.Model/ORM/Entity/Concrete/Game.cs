using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.Model.ORM.Concrete
{
    public class Game:BaseEntity
    {
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public string GameImgURL { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }



    }
}
