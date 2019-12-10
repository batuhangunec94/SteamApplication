using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.Model.ORM.Abstract
{
    public enum Status
    {
        None = 0,
        Active = 1,
        Update = 2,
        Passive = 3
    }
    public interface ICore
    {
        int ID { get; set; }
        DateTime AddDate { get; set; }
        DateTime? UpdateDate { get; set; }
        DateTime? Delete { get; set; }
        Status Status { get; set; }


    }
}
