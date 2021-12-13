using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPhoneRepairAPI.Models
{
    public class Quote_Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Query { get; set; }
        public string Location { get; set; }
        public string Repair_type { get; set; }    

    }
}
