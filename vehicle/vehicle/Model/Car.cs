using System;

namespace vehicle.Model
{
    internal class Car : Vehicle
    {
        public double enginePower;

        public Car(int tires)
        {
            this.tires = tires;
        }
        public Car(int tires, int pathLength) : this(tires)
        {
            this.pathLength = pathLength;
        }
        public Car(int tires, int pathLength, string color) : this(tires, pathLength)
        {
            this.color = color;
        }
        public Car(int tires, int pathLength, string color, int driveTime) : this(tires, pathLength, color)
        {
            this.driveTime = driveTime;
        }
        public Car(int tires, int pathLength, string color, int driveTime, int enginePower) : this(tires, pathLength, color, driveTime)
        {
            this.enginePower = enginePower;
        }
        public Car(int tires, int pathLength, string color, int driveTime, int enginePower, int passgerCount) : this(tires, pathLength, color, driveTime,enginePower)
        {
            this.passgerCount = passgerCount;
        }
        public Car(int tires, int pathLength, string color, int driveTime, int enginePower, int passgerCount,string model) : this(tires, pathLength, color, driveTime, enginePower,enginePower)
        {
            this.model = model;
        }

        public void getInfo()
        {
            Console.WriteLine($"tekerlerin sayi:{tires}|gedilen yol:{pathLength}km|reng:{color}|yola serf olunan zaman:{driveTime}deq|matorun gucu:{enginePower}|sernesin sayi:{passgerCount}|model:{model}");
        }



    }
}
