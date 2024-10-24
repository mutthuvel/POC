
// Singleton Pattern Implementation
// The Singleton class ensures that only one instance of the class is created.

using System;

namespace SingletonPattern
{
    // Singleton class
    public class Singleton
    {
        // Static variable to hold the instance
        private static Singleton instance;

        // Private constructor to prevent instantiation
        private Singleton() { }

        // Method to get the single instance
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // A sample method to demonstrate functionality
        public void ShowMessage()
        {
            Console.WriteLine("Singleton instance is working!");
        }
    }

    // Class to test the Singleton pattern
    public class TestSingleton
    {
        public static void RunTest()
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Both instances are the same.");
            }

            singleton1.ShowMessage();
        }
    }
}
