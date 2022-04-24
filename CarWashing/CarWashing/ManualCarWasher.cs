using System;
using System.Threading;

namespace CarWashing
{
    public class ManualCarWasher : CarWasher
    {
        public ManualCarWasher()
        {
        }

        protected override void Soap()
        {
            Console.WriteLine("Phase: Soap manual");
            Thread.Sleep(2000);
        }

        protected override void WaterWash()
        {
            Console.WriteLine("Cleaning phase: Hot water");
            Thread.Sleep(3000);
        }
    }
}
