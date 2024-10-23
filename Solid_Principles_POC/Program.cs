
using System;

namespace SOLID_Principles_POC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstrates Dependency Inversion Principle (DIP)
            // The OrderProcessor depends on an abstraction (IPaymentProcessor), not on a concrete class
            Console.WriteLine("SOLID Principles POC");
            OrderProcessor orderProcessor = new OrderProcessor(new PaymentProcessor());
            orderProcessor.ProcessOrder(new Order { OrderId = "456", ProductName = "Mobile Phone" });
        }
    }
}
