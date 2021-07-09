namespace DecoratorHomework.CarDecorator
{
    public abstract class CarDecorator : ICar
    {
        protected ICar Car;

        public CarDecorator(ICar car)
        {
            this.Car = car;
        }

        public abstract string MakeCar();       
    }
}
