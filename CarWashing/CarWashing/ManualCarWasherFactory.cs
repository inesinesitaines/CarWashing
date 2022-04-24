namespace CarWashing
{
    public class ManualCarWasherFactory : ICarWasherFactory
    {
        public CarWasher CreateCarWasher()
        {
            return new ManualCarWasher();
        }
    }
}
