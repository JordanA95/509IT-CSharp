using System;
using System.Collections.Generic;
using System.Text;

namespace HarrisCSharp
{
    //C# Contact Class for specifying all fields that appear in both Business and Personal Contact tables in the database.
    public class Contact
    {
        public string ContactID { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddressLine1 { get; set; }
        public string ContactAddressLine2 { get; set; }
        public string ContactCity { get; set; }
        public string ContactPostcode { get; set; }
    }
}
