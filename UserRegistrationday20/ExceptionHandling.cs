using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationday20
{
    public class ExceptionHandling:Exception
    {
        public ExceptionTypes exceptionTypes;
        public enum ExceptionTypes
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALIDE_EMAIL,
            INVALID_PHONENUMBER,
            INVALID_PASSWORD,
            INVALID_ALL_EMAILS,
            INVALID_EMAIL
        }
        public ExceptionHandling(string msg, ExceptionTypes exceptionTypes) : base(msg)
        {
            this.exceptionTypes = exceptionTypes;
        }
    }
}
