using System;
using System.Collections.Generic;
using System.Text;

namespace HW_19_mini_project.Exceptions
{
    internal class INvalidEmailException : Exception
    {
        public INvalidEmailException() : base("Email must contain '@' and '.'")
        {
        }

        public INvalidEmailException(string? message) : base(message)
        {
        }
    }
}
