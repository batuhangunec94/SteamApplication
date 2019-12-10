using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.Model.ORM.Concrete
{
    public enum Role
    {
        None = 0,
        User = 1,
        Admin = 2,
        Moderator = 3,

    }
    public class AppUser:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        List<Game> Games { get; set; }



    }
}
