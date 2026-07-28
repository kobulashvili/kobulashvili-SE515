using System;
using System.Collections.Generic;
using System.Text;


namespace hw14.Exceptions
{
    internal class BankTransferException : Exception
    {
        public BankTransferException()
        {
        }

        public BankTransferException(string? message) : base(message)
        {
        }
    }
}
