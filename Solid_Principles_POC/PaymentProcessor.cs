
namespace SOLID_Principles_POC
{
    public class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(string orderId)
        {
            try
            {
                // Open/Closed: PaymentProcessor can be extended for different payment types without modification
                System.Console.WriteLine($"Payment for order {orderId} processed.");
            }
            catch
            {
                throw; //for following Substitution principle
            }
        }
    }
}
