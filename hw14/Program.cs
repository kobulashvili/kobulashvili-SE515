using hw14.Payments;
using hw14.Exceptions;
using System;

namespace hw14
{
    internal class Program
    {
        static void Main(string[] args)
        {


//              შესაძლებელია ერთ Try catch ბლოკში ყველა exception - ის დაჭერა,
//              მაგრამ დანარჩენ შეცდომებს აღარ აჩვენებს და პირველივე შეცდომაზე ერორდება .


            try
            {
                PaymentMethod paymentTransfer = new BankTransfer
                {
                    Iban = "",
                    BankName = "TBC Bank"
                };
                paymentTransfer.ProcessPayment(300m);

            }
            catch (BankTransferException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }







            try
            {
                CreditCardPayment paymentCreditCard = new CreditCardPayment
                {
                    CardNumber = 0,
                    CardHolder = "name name"
                };

                paymentCreditCard.ProcessPayment(100m);
            }
            catch (CreditCardException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }








            try
            {
                CryptoPayment paymentCrypto = new CryptoPayment
                {
                    WalletAddress = "address",
                    CryptoType = ""
                };
                paymentCrypto.ProcessPayment(500m);
            }
            catch(CryptoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





            try
            {
                PayPalPayment paymentPaypal = new PayPalPayment
                {
                    Email = ""
                };
                paymentPaypal.ProcessPayment(13m);
                                
            }
            catch(PayPalException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}