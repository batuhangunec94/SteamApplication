using SteamApplication.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.Repository.Entity.Concrete
{
    public class BaseRepository
    {
        public ProjectContext db;
        public BaseRepository()
        {
            db = new ProjectContext();
        }
    }
}
