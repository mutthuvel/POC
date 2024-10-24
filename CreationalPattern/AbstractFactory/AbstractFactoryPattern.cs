
// Abstract Factory Pattern Implementation
// Provides an interface for creating families of related or dependent objects without specifying their concrete classes.

using System;

namespace AbstractFactoryPattern
{
    // Abstract Product A
    public interface IAbstractProductA
    {
        void OperationA();
    }

    // Abstract Product B
    public interface IAbstractProductB
    {
        void OperationB();
    }

    // Concrete Product A1
    public class ConcreteProductA1 : IAbstractProductA
    {
        public void OperationA()
        {
            Console.WriteLine("Operation of Product A1.");
        }
    }

    // Concrete Product A2
    public class ConcreteProductA2 : IAbstractProductA
    {
        public void OperationA()
        {
            Console.WriteLine("Operation of Product A2.");
        }
    }

    // Concrete Product B1
    public class ConcreteProductB1 : IAbstractProductB
    {
        public void OperationB()
        {
            Console.WriteLine("Operation of Product B1.");
        }
    }

    // Concrete Product B2
    public class ConcreteProductB2 : IAbstractProductB
    {
        public void OperationB()
        {
            Console.WriteLine("Operation of Product B2.");
        }
    }

    // Abstract Factory
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }

    // Concrete Factory 1
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

    // Concrete Factory 2
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }

    // Class to test the Abstract Factory pattern
    public class TestAbstractFactory
    {
        public static void RunTest()
        {
            IAbstractFactory factory1 = new ConcreteFactory1();
            IAbstractFactory factory2 = new ConcreteFactory2();

            var productA1 = factory1.CreateProductA();
            var productB1 = factory1.CreateProductB();
            var productA2 = factory2.CreateProductA();
            var productB2 = factory2.CreateProductB();

            productA1.OperationA();
            productB1.OperationB();
            productA2.OperationA();
            productB2.OperationB();
        }
    }
}
