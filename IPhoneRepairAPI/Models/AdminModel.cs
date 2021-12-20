using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPhoneRepairAPI.Models
{
    public class CompanyMenu
    {
        public int AutoId { get; set; }
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
        public string Iuser { get; set; }
    }

    public class SubMenuList
    {
        public int AutoId { get; set; }
        public string MenuName { get; set; }
        public string SubMenu { get; set; }
        public string MenuUrl { get; set; }
        public string Iuser { get; set; }
    }
}
