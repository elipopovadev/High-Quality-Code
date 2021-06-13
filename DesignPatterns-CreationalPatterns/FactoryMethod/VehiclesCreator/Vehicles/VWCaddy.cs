namespace VehiclesCreator.Vehicles
{
    public class VWCaddy : IVehicle
    {
        public VWCaddy()
        {
            this.FuelQuantity = 70d;
            this.FuelConsumption = 8;
        }

        public double FuelQuantity { get; private set; }
        public double FuelConsumption { get; private set; }
    }
}

