using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Car : Vehicle
    {
        public Car(double latitude, double longitude, decimal price, decimal speed, int year) : 
            base(latitude, longitude, price, speed, year)
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine("Машина");
            base.GetInfo();
        }
    }
}
