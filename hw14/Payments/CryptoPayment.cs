using System;
using System.Collections.Generic;
using System.Text;
using hw14.Exceptions;

namespace hw14.Payments
{
    internal class CryptoPayment : PaymentMethod
    {

        public string WalletAddress { get; set; }
        public string CryptoType { get; set; }


        public override void ProcessPayment(decimal amount)
        {
            if (string.IsNullOrWhiteSpace(WalletAddress))
            {
                throw new CryptoException("walletAddress is null or empty");
            }

            if (string.IsNullOrWhiteSpace(CryptoType))
            {
                throw new CryptoException("crypto type is null or empty");
            }
            if (amount <= 0)
            {
                throw new CryptoException("amount must be greater than zero");
            }

            Console.WriteLine($"walletaddress :{WalletAddress}, cryptoType:{CryptoType}");
        }
    }
}
