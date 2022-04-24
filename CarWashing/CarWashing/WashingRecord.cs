using System;

namespace CarWashing.Business
{
    public class WashingRecord
    {
        public WashingRecord(Car car)
        {
            Car = car;
            WashingDate = DateTime.Now;
        }

        public DateTime WashingDate { get; private set; }
        public Car Car { get; private set; }

        public override string ToString()
        {
            return Car.GetModel() + ": " + WashingDate.ToString();
        }
    }
}
