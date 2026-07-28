using System;

namespace hw14.Exceptions
{
    internal class CreditCardException : Exception
    {
        public CreditCardException(string message) : base(message)
        {
        }
    }
}