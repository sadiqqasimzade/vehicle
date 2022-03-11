namespace vehicle.Model
{
    internal class Vehicle
    {
        public int tires; //taskda cycle
        public double pathLength; //taskda driveWay
        public string color;
        public int driveTime;
        public string model;
        public int passgerCount;

        public double getSpeed()
        {
            return (pathLength / driveTime) * 60;
        }

    }





}
