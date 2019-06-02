using System;
using System.Collections.Generic;

namespace Planner
{

    class Program
    {

        static void Main(string[] args)
        {

            // Creating buildings
            Building building1 = new AddressConstructor("500 Interstate Blvd.")
            {
                Width = 25.5,
                Depth = 30.6,
                Stories = 100,

            };

            Building building2 = new AddressConstructor("500 SomeOther Blvd.")
            {
                Width = 486.5,
                Depth = 5482,
                Stories = 5,
            };

            Building building3 = new AddressConstructor ("500 Another Place")
            {
                Width = 2545,
                Depth = 324,
                Stories = 22,
            };

            // Constructing buildings using method
            building1.Construct();
            building2.Construct();
            building3.Construct();

            // Purchasing buildings using method
            building1.Purchase("Simon");
            building2.Purchase("Betsy");
            building3.Purchase("Kiri");

            // Creating a list to iterate over

            List<Building> BuildingsList = new List<Building>() {
                building1, 
                building2,
                building3
            };

            foreach(Building building in BuildingsList) {
                Console.WriteLine(building.AddressConstructor);
                Console.WriteLine($"Designed by {building.Designer}");
                Console.WriteLine("-------------");
                Console.WriteLine();
            }
        }
    }
}