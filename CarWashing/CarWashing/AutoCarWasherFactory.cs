namespace CarWashing
{
    public class AutoCarWasherFactory : ICarWasherFactory
    {
        public CarWasher CreateCarWasher()
        {
            return new AutoCarWasher();
        }
    }
}
