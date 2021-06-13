using System;
using VehiclesCreator.Vehicles;

namespace VehiclesCreator.FactoryFolder
{
    public class CaddyFactory : VehicleFactory
    {
        protected override IVehicle MakeVehicle()
        {
            return new VWCaddy();
        }
    }
}
