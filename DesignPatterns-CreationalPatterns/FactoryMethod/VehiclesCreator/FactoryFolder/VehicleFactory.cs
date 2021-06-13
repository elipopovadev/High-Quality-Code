using VehiclesCreator.Vehicles;

namespace VehiclesCreator.FactoryFolder
{
   public abstract class VehicleFactory
    {
        protected abstract Vehicle MakeVehicle(string type);
        public Vehicle CreateVehicle(string type)
        {
            return this.MakeVehicle(type);
        }
    }
}
