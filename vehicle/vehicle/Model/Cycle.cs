using System;

namespace vehicle.Model
{
    internal class Cycle : Vehicle
    {

        public Cycle(int tires, int pathLength, string color, int driveTime, int passgerCount, string model)
        {
            this.tires = tires;
            this.pathLength = pathLength;
            this.color = color;
            this.driveTime = driveTime;
            this.passgerCount = passgerCount;
            this.model = model;
        }

        public void getInfo()
        {
            Console.WriteLine($"tekerlerin sayi:{tires}|gedilen yol:{pathLength}km|reng:{color}|yola serf olunan zaman:{driveTime}deq|sernesin sayi:{passgerCount}|model:{model}");
        }

    }
}
