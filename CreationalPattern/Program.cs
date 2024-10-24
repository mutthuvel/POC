
using System;

namespace CreationalPatternsPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creational Patterns POC!");
            // Uncomment the desired pattern to test

            SingletonPattern.TestSingleton();
            // FactoryMethodPattern.TestFactoryMethod();
            // AbstractFactoryPattern.TestAbstractFactory();
            // BuilderPattern.TestBuilder();
            // PrototypePattern.TestPrototype();
        }
    }
}
