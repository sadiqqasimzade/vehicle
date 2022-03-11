using System;
using vehicle.Model;
namespace vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(4);
            Car car2 = new Car(4, 100);
            Car car3 = new Car(4, 100, "black");
            Car car4 = new Car(4, 100, "black", 60);
            Car car5 = new Car(4, 100, "black", 60, 100);
            Car car6 = new Car(4, 100, "black", 60, 100,5);
            Car car7 = new Car(4, 100, "black", 60, 100, 4, "bmw");

            car1.getInfo();
            car2.getInfo();
            car3.getInfo();
            car4.getInfo();
            car5.getInfo();
            car6.getInfo();
            car7.getInfo();
            Console.WriteLine($"masinin ortalama sureti:  {car7.getSpeed()}km/saat");
            Console.WriteLine();
            Cycle bicycle1 = new Cycle(2);
            Cycle bicycle2 = new Cycle(2, 10);
            Cycle bicycle3 = new Cycle(2, 10, "blue");
            Cycle bicycle4 = new Cycle(2, 10, "blue", 10);
            Cycle bicycle5 = new Cycle(2, 10, "blue", 10, 2);
            Cycle bicycle6 = new Cycle(2, 10, "blue", 10, 2, "bicycle pro max plus");

            bicycle1.getInfo();
            bicycle2.getInfo();
            bicycle3.getInfo();
            bicycle4.getInfo();
            bicycle5.getInfo();
            bicycle6.getInfo();
            Console.WriteLine($"velosipedin ortalama sureti:  {bicycle6.getSpeed()}km/saat");
            Console.WriteLine();
            Bus bus1 = new Bus(6);
            Bus bus2 = new Bus(6, 150);
            Bus bus3 = new Bus(6, 150, "red");
            Bus bus4 = new Bus(6, 150, "red", 50);
            Bus bus5 = new Bus(6, 150, "red", 50, 500);
            Bus bus6 = new Bus(6, 150, "red", 50, 500, 40);
            Bus bus7 = new Bus(6, 150, "red", 50, 500, 40, "volvo");
            
            bus1.getInfo();
            bus2.getInfo();
            bus3.getInfo();
            bus4.getInfo();
            bus5.getInfo();
            bus6.getInfo();
            bus7.getInfo();
            bus7.getSpeed();

            Console.WriteLine($"avtobusun ortalama sureti:  {bus7.getSpeed()}km/saat");

           

            Console.ReadLine();
        }
    }
}
