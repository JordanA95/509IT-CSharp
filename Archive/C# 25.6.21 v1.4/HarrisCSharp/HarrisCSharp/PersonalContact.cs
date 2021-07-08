using System;
using System.Collections.Generic;
using System.Text;

namespace HarrisCSharp
{
    //C# PersonalContact Class for specifying ContactPersonalTel field in Personal Contact table in the database.
    public class PersonalContact : Contact
    //PersonalContact class inherits all feilds specified in Contact class.
    {
        public string ContactPersonalTel { get; set; }
    }
}
