
namespace SOLID_Principles_POC
{
    public class OrderProcessor : IOrderProcessor
    {
        private readonly IPaymentProcessor _paymentProcessor;

        // Dependency Inversion Principle (DIP): Depend on an abstraction (IPaymentProcessor) instead of a concrete class.
        public OrderProcessor(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        // Here the method is following Single Responsibility: Handles only order processing
        public void ProcessOrder(Order order)
        {
            // Delegate payment processing to the PaymentProcessor.
            _paymentProcessor.ProcessPayment(order.OrderId);
            System.Console.WriteLine($"Order {order.OrderId} processed.");
        }
    }
}
