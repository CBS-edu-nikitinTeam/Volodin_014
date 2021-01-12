using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    abstract class Vehicle
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public decimal Price { get; private set; }
        public decimal Speed { get; private set; }
        public int Year { get; private set; }

        protected Vehicle(double latitude, double longitude, decimal price, decimal speed, int year)
        {
            Latitude = latitude;
            Longitude = longitude;
            Price = price;
            Speed = speed;
            Year = year;
        }

        // Хорошо сделал, но я бы немного оптимизировал.
        public virtual void GetInfo()
        {
            Console.WriteLine($"Ширина:{Latitude}");
            Console.WriteLine($"Долгота:{Longitude}");
            Console.WriteLine($"Цена:{Price}");
            Console.WriteLine($"Скорость:{Speed}");
            Console.WriteLine($"Год выпуска:{Year}");
        }
    }
}
