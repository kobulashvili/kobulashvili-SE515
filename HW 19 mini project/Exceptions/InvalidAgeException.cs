using System;
using System.Collections.Generic;
using System.Text;

namespace HW_19_mini_project.Exceptions
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base("Age must be greater than 0")
        {
        }

        public InvalidAgeException(string? message) : base(message)
        {
        }
    }
}
