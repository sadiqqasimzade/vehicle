using System;
using vehicle.Model;
namespace vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car(4, 100, "black", 60, 100, 4, "bmw");
            Cycle family_bicycle = new Cycle(2, 10, "blue", 10, 2, "[insert model name]");
            Bus baku_airport = new Bus(6, 150, "red", 50, 500, 40, "volvo");

            bmw.getInfo();
            Console.WriteLine();
            family_bicycle.getInfo();
            Console.WriteLine();
            baku_airport.getInfo();
            Console.WriteLine();

            Console.WriteLine($"masinin ortalama sureti:    {bmw.getSpeed()}km/saat");
            Console.WriteLine($"velosipedin ortalama sureti:{family_bicycle.getSpeed()}km/saat");
            Console.WriteLine($"avtobusun ortalama sureti:  {baku_airport.getSpeed()}km/saat");

            Console.ReadLine();
        }
    }
}
