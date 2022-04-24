namespace CarWashing.Business
{
    public class AutoCarWasherFactory : ICarWasherFactory
    {
        public CarWasher CreateCarWasher()
        {
            return new AutoCarWasher();
        }
    }
}
