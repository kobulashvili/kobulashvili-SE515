using System;
using System.Collections.Generic;
using System.Text;

namespace hw14.Exceptions
{
    internal class PayPalException : Exception
    {
        public PayPalException()
        {
        }

        public PayPalException(string? message) : base(message)
        {
        }
    }
}
