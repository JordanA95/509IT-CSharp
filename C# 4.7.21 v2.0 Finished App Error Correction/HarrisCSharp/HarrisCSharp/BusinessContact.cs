using System;
using System.Collections.Generic;
using System.Text;

namespace HarrisCSharp
{
    //C# BusinessContact Class for specifying ContactBusinessTel field in Business Contact table in the database.
    public class BusinessContact : Contact
    //BusinessContact class inherits all fields specified in Contact class.
    {
        public string ContactBusinessTel { get; set; }
    }
}
