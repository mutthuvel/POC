
namespace SOLID_Principles_POC
{
    // Interface Segregation Principle (ISP): This interface contains only the method needed for payment processing.
    // Clients (like OrderProcessor) should not be forced to implement methods they don’t use.
    // Base class interface expects failure to throw an exception
    public interface IPaymentProcessor
    {
        void ProcessPayment(string orderId);// Expected to throw an exception if failed
    }
}
