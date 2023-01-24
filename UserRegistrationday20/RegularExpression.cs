﻿using System;
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
            if(Regex.IsMatch(inputs, patternFirstName))
            {
                return true;
            }
            else
            {
                throw new ExceptionHandling("Invalid First Name", ExceptionHandling.ExceptionTypes.INVALID_FIRST_NAME);
            }
        }
        //Created last name method
        public bool lastName()
        {
            if(Regex.IsMatch(inputs, patternLastName))
            {
                return true;
            }
            else
            {
                throw new ExceptionHandling("Invalid Last Name", ExceptionHandling.ExceptionTypes.INVALID_LAST_NAME);
            }
        }
        //Created email method
        public bool validEmail()
        {
            if (Regex.IsMatch(inputs, patternValidEmail))
            {
                return true;
            }
            else
            {
                throw new ExceptionHandling("Invalid Email", ExceptionHandling.ExceptionTypes.INVALID_EMAIL);
            }
        }
        //Created phone number method
        public bool phoneNumber()
        {
            if (Regex.IsMatch(inputs, patternPhoneNumber))
            {
                return true;
            }
            else
            {
                throw new ExceptionHandling("Invalid Phone Number", ExceptionHandling.ExceptionTypes.INVALID_PHONENUMBER);
            }
        }
        //Created password method
        public bool password()
        {
            if (Regex.IsMatch(inputs, patternPassword))
            {
                return true;
            }
            else
            {
                throw new ExceptionHandling("Invalid Password", ExceptionHandling.ExceptionTypes.INVALID_PASSWORD);
            }
        }
        //Created validate Emails method
        public bool validateEmails()
        {
            if (Regex.IsMatch(inputs, patternValidateEmails))
            {
                return true;
            }
            else
            {
                throw new ExceptionHandling("Invalid all emails", ExceptionHandling.ExceptionTypes.INVALID_ALL_EMAILS);
            }
        }
       
    }
}