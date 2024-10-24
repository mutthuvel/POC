using System;

namespace BuilderPattern
{
    // The 'Product' class that represents the complex object to be built.
    public class House
    {
        public string Basement { get; set; }
        public string Structure { get; set; }
        public string Roof { get; set; }
        public string Interior { get; set; }

        // Method to display the completed house.
        public void ShowHouse()
        {
            Console.WriteLine($"House built with: \nBasement: {Basement}, \nStructure: {Structure}, \nRoof: {Roof}, \nInterior: {Interior}");
        }
    }

    // The 'Builder' interface defines all steps to build a house.
    public interface IHouseBuilder
    {
        void BuildBasement();
        void BuildStructure();
        void BuildRoof();
        void BuildInterior();
        House GetHouse();
    }

    // Concrete builder for a specific type of house (e.g., Igloo).
    public class IglooHouseBuilder : IHouseBuilder
    {
        private House house;

        public IglooHouseBuilder()
        {
            house = new House(); // Initializing the house object.
        }

        public void BuildBasement()
        {
            house.Basement = "Ice basement";
        }

        public void BuildStructure()
        {
            house.Structure = "Ice blocks structure";
        }

        public void BuildRoof()
        {
            house.Roof = "Ice dome roof";
        }

        public void BuildInterior()
        {
            house.Interior = "Ice furniture";
        }

        public House GetHouse()
        {
            return house;
        }
    }

    // Another Concrete builder for a different type of house (e.g., Wooden House).
    public class WoodenHouseBuilder : IHouseBuilder
    {
        private House house;

        public WoodenHouseBuilder()
        {
            house = new House(); // Initializing the house object.
        }

        public void BuildBasement()
        {
            house.Basement = "Wooden poles basement";
        }

        public void BuildStructure()
        {
            house.Structure = "Wooden structure";
        }

        public void BuildRoof()
        {
            house.Roof = "Wooden roof";
        }

        public void BuildInterior()
        {
            house.Interior = "Wooden furniture";
        }

        public House GetHouse()
        {
            return house;
        }
    }

    // The 'Director' class that constructs a house using the builder interface.
    public class ConstructionEngineer
    {
        private IHouseBuilder houseBuilder;

        // Constructor takes a specific builder.
        public ConstructionEngineer(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        // Method to construct the house step by step.
        public House ConstructHouse()
        {
            houseBuilder.BuildBasement();
            houseBuilder.BuildStructure();
            houseBuilder.BuildRoof();
            houseBuilder.BuildInterior();
            return houseBuilder.GetHouse();
        }
    }

    // Class to test the Builder pattern.
    public class TestBuilderPattern
    {
        public static void RunTest()
        {
            // Building an Igloo House
            IHouseBuilder iglooBuilder = new IglooHouseBuilder();
            ConstructionEngineer engineer1 = new ConstructionEngineer(iglooBuilder);
            House iglooHouse = engineer1.ConstructHouse();
            Console.WriteLine("Igloo House:");
            iglooHouse.ShowHouse();

            // Building a Wooden House
            IHouseBuilder woodenBuilder = new WoodenHouseBuilder();
            ConstructionEngineer engineer2 = new ConstructionEngineer(woodenBuilder);
            House woodenHouse = engineer2.ConstructHouse();
            Console.WriteLine("\nWooden House:");
            woodenHouse.ShowHouse();
        }
    }
}
