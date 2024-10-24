
// Factory Method Pattern Implementation
// Defines an interface for creating objects, but lets subclasses decide which class to instantiate.

using System;

namespace FactoryMethodPattern
{
    // Product interface
    public interface IProduct
    {
        void Operation();
    }

    // Concrete Product 1
    public class ConcreteProductA : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Operation of Product A.");
        }
    }

    // Concrete Product 2
    public class ConcreteProductB : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Operation of Product B.");
        }
    }

    // Creator class
    public abstract class Creator
    {
        // Factory Method
        public abstract IProduct CreateProduct();

        public void SomeOperation()
        {
            IProduct product = CreateProduct();
            product.Operation();
        }
    }

    // Concrete Creator 1
    public class ConcreteCreatorA : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }

    // Concrete Creator 2
    public class ConcreteCreatorB : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }

    // Class to test the Factory Method pattern
    public class TestFactoryMethod
    {
        public static void RunTest()
        {
            Creator creator1 = new ConcreteCreatorA();
            Creator creator2 = new ConcreteCreatorB();

            creator1.SomeOperation();
            creator2.SomeOperation();
        }
    }
}
