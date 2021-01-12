using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>() 
            { 
                new Plane(423, 4.23, 4.56, 600000, 700, 2011), 
                new Ship(800, "Cuba", 4.67, 3.45, 3000000, 200, 2020),
                new Car(4.56, 4.56, 700, 300, 2015)
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.GetInfo();
                Console.WriteLine("\n");
            }
            
        }
    }
}
