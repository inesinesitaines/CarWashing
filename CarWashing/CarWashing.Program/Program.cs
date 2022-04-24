using System;

namespace CarWashing.Program
{
    internal class Program
    {
        static void Main()
        {
            Car[] cars =
            {
                new Car("Ferrari 296 GTB"),
                new Car("Seat León"),
                new Car("Citroën C4"),
                new Car("Renault Captur"),
                new Car("Audi A7")
            };

            ManualCarWasherFactory manualCarWasherFactory = new();
            CarWasher manualCarWasher = manualCarWasherFactory.CreateCarWasher();

            foreach(var car in cars)
            {
                manualCarWasher.Wash(car);
            }

            manualCarWasher.GetWashingRecords().ForEach(R => Console.WriteLine(R));

            AutoCarWasherFactory autoCarWasherFactory = new();
            CarWasher autoCarWasher = autoCarWasherFactory.CreateCarWasher();

            foreach(var car in cars)
            {
                autoCarWasher.Wash(car);
            }

            autoCarWasher.GetWashingRecords().ForEach(R => Console.WriteLine(R));
        }
    }
}
