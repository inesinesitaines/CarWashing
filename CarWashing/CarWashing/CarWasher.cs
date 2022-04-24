using System;
using System.Collections.Generic;

namespace CarWashing.Business
{
    public abstract class CarWasher
    {
        private readonly List<WashingRecord> _washingRecords = new();

        public void Wash(Car car)
        {
            Console.WriteLine("Washing Car: " + car.GetModel());
            _washingRecords.Add(new WashingRecord(car));
            Soap();
            WaterWash();
        }

        protected abstract void Soap();
        protected abstract void WaterWash();

        public List<WashingRecord> GetWashingRecords() => _washingRecords;
    }
}
