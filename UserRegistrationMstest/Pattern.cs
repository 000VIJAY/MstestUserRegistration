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
        readonly string ValidName = "^[A-Z]{1}[A-Za-z]{3,8}";
        readonly string validEmailId = @"^[A-Za-z0-9]+@[A-Za-z0-9]+.[a-z]{2,5}(.[a-z]{2,5})$";
        readonly string validMobileNumber = "^[1-9]{1,3} +[6-9]{1}[0-9]{9}$";
        readonly string validPassword = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=-])[a-zA-Z0-9!@#$%^&*()_+=-]{8,15}$";
        public string ValidateFirstName(string FirstName)
        {
            try
            {
                bool v = Regex.IsMatch(FirstName, ValidName);
                if (v.Equals(true))
                {
                    Console.WriteLine("true");
                    return "true";
                }
                if (FirstName == null)
                {
                    throw new ExceptionHan("First name should not be null", UserExp.null_First_Name);
                }
                if (FirstName.Length < 1)
                {
                    throw new ExceptionHan("First name should not be empty", UserExp.Empty_First_Name);
                }
                if (v.Equals(false))
                {
                    throw new ExceptionHan("First Name should start with Capital Letter only", UserExp.Invalid_First_Name);
                }
            }
            catch (ExceptionHan ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public string ValidateLastName(string LastName)
        {
            try
            {
                bool v = Regex.IsMatch(LastName, ValidName);
                if (v.Equals(true))
                {
                    Console.WriteLine("true");
                    return "true";
                }
                if (LastName == null)
                {
                    throw new ExceptionHan("Last name should not be null", UserExp.null_Last_Name);
                }
                if (LastName.Length < 1)
                {
                    throw new ExceptionHan("Last name should not be empty", UserExp.Empty_Last_Name);
                }
                if (v.Equals(false))
                {
                    throw new ExceptionHan("Last Name should start with Capital Letter only", UserExp.Invalid_Last_Name);
                }
            }
            catch (ExceptionHan ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public string ValidateEmail(string Email)
        {
            try
            {
                bool v = Regex.IsMatch(Email, validEmailId);
                if (v.Equals(true))
                {
                    Console.WriteLine("true");
                    return "true";
                }
                if (Email == null)
                {
                    throw new ExceptionHan("Email should not be null", UserExp.Null_Email_Id);
                }
                if (Email.Length < 1)
                {
                    throw new ExceptionHan("Email should not be empty", UserExp.Empty_Email);
                }
                if (v.Equals(false))
                {
                    throw new ExceptionHan("Given Email is not in proper mannner ", UserExp.Invalid_Email);
                }
            }
            catch (ExceptionHan ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public string ValidatePhoneNumber(string PhoneNumber)
        {
            try
            {
                bool v = Regex.IsMatch(PhoneNumber, validMobileNumber);
                if (v.Equals(true))
                {
                    Console.WriteLine("true");
                    return "true";
                }
                if (PhoneNumber.Length < 1)
                {
                    throw new ExceptionHan("Phone Number should not be empty", UserExp.Empty_Phone_Number);
                }
                if (v.Equals(false))
                {
                    throw new ExceptionHan("Given Phone Number is not in proper mannner , for proper Phone Number follow given instruction." +
                                            " 1.County code between (1-3) digits and shold be only 10 digit of number" +
                                            " 2.Only Give Number as value", UserExp.Invalid_Phone_Number);
                }
            }
            catch (ExceptionHan ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public string ValidatePassword(string Password)
        {
            try
            {
                bool v = Regex.IsMatch(Password, validPassword);
                if (v.Equals(true))
                {
                    Console.WriteLine("true");
                    return "true";
                }
                if (Password.Length < 1)
                {
                    throw new ExceptionHan("Password should not be empty", UserExp.Empty_Password);
                }
                if (v.Equals(false))
                {
                    throw new ExceptionHan("Given Password is not in proper mannner, for proper Password follow given instruction" +
                                            " 1. Number of character  should be between (8-15) " +
                                            "2.Minimum One Upper Character , one Lower character , One Special character , one number present", UserExp.Invalid_Password);
                }
            }
            catch (ExceptionHan ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
