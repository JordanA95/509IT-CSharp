using System;
using System.Collections.Generic;
using System.Text;

namespace HarrisCSharp
{
    //C# Contact Class for specifying all fields that appear in both Business and Personal Contact tables in the database.
    public abstract class Contact
    {
        public int ContactID { get; set; }
        public string ContactFName { get; set; }
        public string ContactLName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddr1 { get; set; }
        public string ContactAddr2 { get; set; }
        public string ContactCity { get; set; }
        public string ContactPostcode { get; set; }
    }
}
