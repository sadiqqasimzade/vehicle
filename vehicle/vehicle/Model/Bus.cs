using System;

namespace vehicle.Model
{
    internal class Bus : Vehicle
    {
        public double enginePower;
        public Bus(int tires, int pathLength, string color, int driveTime, int enginePower, int passgerCount, string model)
        {
            this.tires = tires;
            this.pathLength = pathLength;
            this.color = color;
            this.driveTime = driveTime;
            this.enginePower = enginePower;
            this.passgerCount = passgerCount;
            this.model = model;
        }


        public void getInfo()
        {
            Console.WriteLine($"tekerlerin sayi:{tires}|gedilen yol:{pathLength}km|reng:{color}|yola serf olunan zaman:{driveTime}deq|matorun gucu:{enginePower}|sernesin sayi:{passgerCount}|model:{model}");
        }
    }
}
