using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationMstest
{
    public class LambdaExpression
    {
        readonly string ValidName = "^[A-Z]{1}[A-Za-z]{3,8}";
        readonly string validEmailId = @"^[A-Za-z0-9]+@[A-Za-z0-9]+.[a-z]{2,5}(.[a-z]{2,5})$";
        readonly string validMobileNumber = "^[1-9]{1,3} +[6-9]{1}[0-9]{9}$";
        readonly string validPassword = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=-])[a-zA-Z0-9!@#$%^&*()_+=-]{8,15}$";

        public string ValidateFirstName(string firstName) => Regex.IsMatch(firstName, ValidName) ? "First Name is Valid" : "First Name is not Valid";
        public string ValidateLastName(string LastName) => Regex.IsMatch(LastName, ValidName) ? "Last Name is Valid" : "Last Name is not Valid";
        public string ValidateEmailId(string Email) => Regex.IsMatch(Email, validEmailId) ? "Email is Valid" : "Email is not Valid";
        public string PhoneNumber(string PhoneNumber) => Regex.IsMatch(PhoneNumber, validMobileNumber) ? "Phone Number is Valid" : "Phone Number is not Valid";
        public string ValidatePassword(string Password) => Regex.IsMatch(Password, validPassword) ? "Password is Valid" : "Password is not Valid";
    }
}
