using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationMstest
{
    public class Pattern
    {
        public string ValidFirstName = "^[A-Z]{1}";
        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, ValidFirstName);
        }
    }
}
