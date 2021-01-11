using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Ship : Vehicle
    {
        public int Passengers { get; private set; }
        public string Port { get; private set; }
        public Ship(int passengers, string port, double latitude, double longitude, decimal price, decimal speed, int year) : base(latitude, longitude, price, speed, year)
        {
            Passengers = passengers;
            Port = port;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Корабль");
            Console.WriteLine($"Кол-во пассажиров:{Passengers}");
            Console.WriteLine($"Порт приписки:{Port}");
            Console.WriteLine($"Ширина:{Latitude}");
            Console.WriteLine($"Долгота:{Longitude}");
            Console.WriteLine($"Цена:{Price}");
            Console.WriteLine($"Скорость:{Speed}");
            Console.WriteLine($"Год выпуска:{Year}");
        }
    }
}
