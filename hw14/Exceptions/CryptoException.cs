using System;
using System.Collections.Generic;
using System.Text;

namespace hw14.Exceptions
{
    internal class CryptoException : Exception
    {
        public CryptoException()
        {
        }

        public CryptoException(string? message) : base(message)
        {
        }
    }
}
