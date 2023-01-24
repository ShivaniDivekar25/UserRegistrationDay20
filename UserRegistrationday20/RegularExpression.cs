using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationday20
{
    public class RegularExpression
    {
        //Created Variable declaration
        public string inputs;
        public string patternFirstName= "^[A-Z]{1}[a-z]{2,}$";
        public string patternLastName = "^[A-Z]{1}[a-z]{2,}$";
        public string patternValidEmail = "^[a-z]{3}.[a-z]{2,}@[a-z]{2}.[a-z]{2}.[a-z]{2}$";
        public string patternPhoneNumber = "^[0-9]{2}[ ][0-9]{10}$";
        public string patternPassword = "^[A-Z]{1}[a-z]{4,}(@|#|$|&){1}[0-9]{1,}$";
        public string patternValidateEmails = "^[a-zA-Z]{3}[_,.,+,-]?[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.(com|com.au|net|co.in|com.com)$";
        //Default Constructor
        public RegularExpression()
        {

        }
        //Parameterized Costructor
        public RegularExpression(string inputs)
        {
            this.inputs = inputs;
        }
        //Created first name method
        public bool firstName()
        {
            return (Regex.IsMatch(inputs, patternFirstName));
        }
        //Created last name method
        public bool lastName()
        {
            return (Regex.IsMatch(inputs, patternLastName));
        }
        //Created email method
        public bool validEmail()
        {
            return (Regex.IsMatch(inputs,patternValidEmail));
        }
        //Created phone number method
        public bool phoneNumber()
        {
            return (Regex.IsMatch(inputs, patternPhoneNumber));
        }
        //Created password method
        public bool password()
        {
            return (Regex.IsMatch(inputs, patternPassword));
        }
        //Created validate Emails method
        public bool validateEmails()
        {
            return (Regex.IsMatch(inputs, patternValidateEmails));
        }
       
    }
}