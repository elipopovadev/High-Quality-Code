using System;
using VehiclesCreator.Vehicles;

namespace VehiclesCreator.FactoryFolder
{
    public class PassatFactory : VehicleFactory
    {
        protected override IVehicle MakeVehicle()
        {
            return new VWPassat();
        }
    }
}
