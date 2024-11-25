using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomeWork
{
    internal class InvalidUserCredentialsException : Exception
    {
        public const string Code = "invalid_user_credentials";

        public InvalidUserCredentialsException()
            : base("Username or password is incorrect")
        {
            
        }

    }
}
