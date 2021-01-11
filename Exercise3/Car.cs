using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Car : Vehicle
    {
        public Car(double latitude, double longitude, decimal price, decimal speed, int year) : base(latitude, longitude, price, speed, year)
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine("Машина");
            Console.WriteLine($"Ширина:{Latitude}");
            Console.WriteLine($"Долгота:{Longitude}");
            Console.WriteLine($"Цена:{Price}");
            Console.WriteLine($"Скорость:{Speed}");
            Console.WriteLine($"Год выпуска:{Year}");
        }
    }
}
