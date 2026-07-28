using hw14.Exceptions;
using System;

namespace hw14.Payments
{
    internal class CreditCardPayment : PaymentMethod
    {
        public int CardNumber { get; set; }
        public string CardHolder { get; set; }

        public override void ProcessPayment(decimal amount)
        {
            if (CardNumber <= 0)
                throw new CreditCardException("Card number is invalid");

            if (string.IsNullOrWhiteSpace(CardHolder))
                throw new CreditCardException("Card holder is empty");

            if (amount <= 0)
                throw new CreditCardException("Amount must be greater than zero");

            Console.WriteLine($"CardNumber: {CardNumber}, CardHolder: {CardHolder}, Amount: {amount}");
        }
    }
}