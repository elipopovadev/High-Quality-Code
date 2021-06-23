namespace Decorator.CarDecorator
{
    public class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }

        public override void AddEngine(ICar car)
        {
            if (car is BMW)
            {
                BMW BMWCar = (BMW)car;
                BMWCar.Engine = "Diesel Engine";
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
