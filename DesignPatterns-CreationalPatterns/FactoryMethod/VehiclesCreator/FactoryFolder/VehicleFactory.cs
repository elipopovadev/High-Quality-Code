using VehiclesCreator.Vehicles;

namespace VehiclesCreator.FactoryFolder
{
   public abstract class VehicleFactory
    {
        protected abstract IVehicle MakeVehicle();
        public IVehicle CreateVehicle()
        {
            return this.MakeVehicle();
        }
    }
}
