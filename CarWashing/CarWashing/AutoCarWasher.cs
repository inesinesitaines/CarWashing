using System;
using System.Threading;

namespace CarWashing.Business
{
    internal class AutoCarWasher : CarWasher
    {
        public AutoCarWasher()
        {
        }

        protected override void Soap()
        {
            Console.WriteLine("Phase: Soap auto");
            Thread.Sleep(1000);
        }

        protected override void WaterWash()
        {
            Console.WriteLine("Phase: Cold water");
            Thread.Sleep(2000);
        }
    }
}
