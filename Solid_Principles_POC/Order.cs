
namespace SOLID_Principles_POC
{
    public class Order
    {
        // This class is only responsible for storing order details.
        // It follows the Single Responsibility Principle (SRP).
        public string OrderId { get; set; }
        public string ProductName { get; set; }
    }
}
