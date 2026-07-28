using System;
using System.Collections.Generic;
using System.Text;

namespace HW_19_mini_project.Exceptions
{
    internal class InvalidEmailModelException : Exception
    {
        public InvalidEmailModelException() 
        {
        }

        public InvalidEmailModelException(string? message) : base(message)
        {
        }
    }
}
