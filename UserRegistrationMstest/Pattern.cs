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
        public string validLastName = @"^[A-Z]{1}[a-z]{3,10}";
        public string validEmailId = @"^[A-Za-z0-9._]+@[A-Za-z0-9]+.[a-z]{2,5}$";
        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, ValidFirstName);
        }
        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, validLastName);
        }
        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, validEmailId);
        }
    }
}
