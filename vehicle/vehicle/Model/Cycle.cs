using System;

namespace vehicle.Model
{
    internal class Cycle : Vehicle
    {

        public Cycle(int tires)
        {
            this.tires = tires;
        }
        public Cycle(int tires, int pathLength):this(tires)
        {
            this.pathLength = pathLength;
        }
        public Cycle(int tires, int pathLength, string color):this(tires,pathLength)
        {
            this.color = color;
        }
        public Cycle(int tires, int pathLength, string color, int driveTime) : this(tires, pathLength, color)
        {
            this.driveTime = driveTime;
        }
        public Cycle(int tires, int pathLength, string color, int driveTime, int passgerCount):this(tires,pathLength,color,driveTime)
        {
            this.passgerCount = passgerCount;
        }
        public Cycle(int tires, int pathLength, string color, int driveTime, int passgerCount,string model) : this(tires, pathLength, color, driveTime,passgerCount)
        {
            this.model = model;
        }

        public void getInfo()
        {
            Console.WriteLine($"tekerlerin sayi:{tires}|gedilen yol:{pathLength}km|reng:{color}|yola serf olunan zaman:{driveTime}deq|sernesin sayi:{passgerCount}|model:{model}");
        }
        

    }
}
