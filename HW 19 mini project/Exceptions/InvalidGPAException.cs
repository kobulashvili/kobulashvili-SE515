using System;
using System.Collections.Generic;
using System.Text;

namespace HW_19_mini_project.Exceptions
{
    internal class InvalidGPAException : Exception
    {
        public InvalidGPAException()
        {
        }

        public InvalidGPAException(string? message) : base(message)
        {
        }
    }
}
