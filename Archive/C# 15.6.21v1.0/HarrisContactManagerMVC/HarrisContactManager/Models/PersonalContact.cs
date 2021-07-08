using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactManager.Models
{
    public class PersonalContact
    {
        public int PersonalContactID { get; set; }
        public string PersonalContactFName { get; set; }
        public string PersonalContactLName { get; set; }
        public string PersonalContactTel { get; set; }
        public string PeronalContactEmail { get; set; }
        public string PersonalContactAddr1 { get; set; }
        public string PersonalContactAddr2 { get; set; }
        public string PersonalContactCity { get; set; }
        public string PersonalPostcode { get; set; }

    }
}
