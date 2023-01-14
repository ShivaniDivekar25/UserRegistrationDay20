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
        //Created first name method
        public string fisrtName(string input)          
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
        //Created Test pattern method
        public string TestPattern(string pattern, string input)         
        {
            if (Regex.IsMatch(input, pattern))
            {
                return "valid";
            }
            else
            {
                return "invalid";
            }
        }
    }
}
