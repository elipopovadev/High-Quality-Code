using VehiclesCreator.Vehicles;

namespace VehiclesCreator.FactoryFolder
{
   public interface IFactoryCreator
    {
        public IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption)
        {
            IVehicle vehicle = null;
            return vehicle;
        }
    }
}
