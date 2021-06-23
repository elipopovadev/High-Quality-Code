namespace Decorator.CarDecorator
{
    public abstract class CarDecorator : ICar
    {
        protected ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public abstract void AddEngine(ICar car);

        public abstract ICar ManufactureCar();      
    }
}
