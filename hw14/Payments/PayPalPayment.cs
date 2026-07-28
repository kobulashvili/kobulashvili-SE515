using System;
using System.Collections.Generic;
using System.Text;
using hw14.Exceptions;

namespace hw14.Payments
{
    internal class PayPalPayment : PaymentMethod
    {

        public string Email { get; set; }

        public override void ProcessPayment(decimal amount)
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                throw new PayPalException("Email is null or empty");
            }

            if (amount <= 0)
            {
                throw new PayPalException("amount must be greater than zero");
            }

            Console.WriteLine($"Email: {Email}, amount: {amount}");
        }
    }
}
