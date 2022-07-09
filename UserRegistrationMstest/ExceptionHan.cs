using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationMstest
{
    public enum UserExp
    {
        null_First_Name,
        Empty_First_Name,
        Invalid_First_Name,
        null_Last_Name,
        Empty_Last_Name,
        Invalid_Last_Name,
        Empty_Email,
        Null_Email_Id,
        Invalid_Email,
        Empty_Phone_Number,
        Invalid_Phone_Number,
        Empty_Password,
        Invalid_Password
    }
    public class ExceptionHan : Exception
    { 
        public UserExp exp;
        public ExceptionHan(string message, UserExp exp) : base(message)
        {
            this.exp = exp;
        }
    }
}
