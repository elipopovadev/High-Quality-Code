namespace Decorator.CarDecorator
{
   public class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar car) : base(car)
        {
        }

        public override void AddEngine(ICar car)
        {
            if (car is BMW)
            {
                BMW BMWCar = (BMW)car;
                BMWCar.Engine = "Petrol Engine";
            }
        }

        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }
    }
}
