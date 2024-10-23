using SOLID_Principles_POC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles_POC
{
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(string orderId)
        {
            try
            {
                // New logic specific to credit card payments
                System.Console.WriteLine($"Credit card payment for order {orderId} processed.");
            }
            catch {
                System.Console.WriteLine("Voilate substitution principle");
            }
        }
    }
}
