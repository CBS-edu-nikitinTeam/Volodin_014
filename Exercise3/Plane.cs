using System;

namespace Exercise3
{
    class Plane : Vehicle
    {
        public int Heigh { get; private set; }
        public Plane(int heigh, double latitude, double longitude, decimal price, decimal speed, int year) : base(latitude, longitude, price, speed, year)
        {
            Heigh = heigh;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Самолет");
            Console.WriteLine($"Высота:{Heigh}");
            Console.WriteLine($"Ширина:{Latitude}");
            Console.WriteLine($"Долгота:{Longitude}");
            Console.WriteLine($"Цена:{Price}");
            Console.WriteLine($"Скорость:{Speed}");
            Console.WriteLine($"Год выпуска:{Year}");
        }
    }
}
