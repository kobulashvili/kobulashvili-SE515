using hw14.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace hw14.Payments
{
    internal class BankTransfer : PaymentMethod
    {
        public BankTransfer()
        {
        }

        public string Iban { get; set; }
        public string BankName { get; set; }
        public override void ProcessPayment(decimal amount)
        {

            if (string.IsNullOrEmpty(Iban))
            {
                throw new BankTransferException("Iban is not correct");
            }

            if (string.IsNullOrWhiteSpace(BankName))
            {
                throw new BankTransferException("bank name is not correct");
            }
            if(amount <= 0)
            {
                throw new BankTransferException("amount must be greater then zero");
            }

            Console.WriteLine(
                 "Processing bank transfer payment of {0:C} from IBAN {1} at {2}.",
                 amount, Iban, BankName);
        }
    }
}
