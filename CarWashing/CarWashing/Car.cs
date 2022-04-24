namespace CarWashing.Business
{
    public class Car
    {
        private readonly string _model;
        public Car(string model)
        {
            _model = model;
        }

        public string GetModel() => _model;
    }
}
