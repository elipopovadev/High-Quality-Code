namespace VehiclesCreator.Vehicles
{
    public class VWPassat : IVehicle
    {
        public VWPassat()
        {
            this.FuelQuantity = 60d;
            this.FuelConsumption = 10;
        }

        public double FuelQuantity { get; private set; }
        public double FuelConsumption { get; private set; }
    }
}
