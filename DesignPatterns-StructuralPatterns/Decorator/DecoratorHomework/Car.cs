namespace DecoratorHomework
{
   public class Car : ICar
    {
        public Car(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; private set; }
        public double FuelConsumption { get; private set; }

        public string MakeCar()
        {
            return "Car";
        }
    }
}
