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
        public string inputs;
        public RegularExpression()
        {

        }
        public RegularExpression(string inputs)
        {
            this.inputs = inputs;
        }
        //Created first name method
        public string firstName(string input)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return TestPattern(pattern, input);
        }
        //Created last name method
        public string lastName(string input)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return TestPattern(pattern, input);
        }
        //Created email method
        public string validEmail(string input)
        {
            string pattern = "^[a-z]{3}.[a-z]{2,}@[a-z]{2}.[a-z]{2}.[a-z]{2}$";
            return TestPattern(pattern, input);
        }
        //Created phone number method
        public string phoneNumber(string input)
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}$";
            return TestPattern(pattern, input);
        }
        //Created password method
        public string password(string input)
        {
            string pattern = "^[A-Z]{1}[a-z]{4,}(@|#|$|&){1}[0-9]{1,}$";
            return TestPattern(pattern, input);
        }
        //Created validate Emails method
        public string validateEmails(string input)
        {
            string pattern = "^[a-zA-Z]{3}[_,.,+,-]?[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.(com|com.au|net|co.in|com.com)$";
            return TestPattern(pattern, input);
        }
        //Created Test pattern method
        public string TestPattern(string pattern, string inputs)
        {
            try
            {
                if (Regex.IsMatch(inputs, pattern))
                {
                    return "valid";
                }
                else if (inputs.Equals(string.Empty))
                {
                    Console.WriteLine();
                    throw new CustomRegularExpressionException("Message should not be empty", CustomRegularExpressionException.ExceptionTypes.EMPTY_INPUT);
                }
                else
                {
                    return "Invalid";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomRegularExpressionException("Message should not be empty", CustomRegularExpressionException.ExceptionTypes.EMPTY_INPUT);
            }
        }
    }
}