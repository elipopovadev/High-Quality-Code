namespace VehiclesCreator.Vehicles
{
   public class Boat : IVehicle
    {
        public Boat(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; private set; }
        public double FuelConsumption { get; private set; }
    }
}
