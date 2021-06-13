using System;
using VehiclesCreator.Vehicles;

namespace VehiclesCreator.FactoryFolder
{
    public class VWFactory : VehicleFactory
    {
        protected override Vehicle MakeVehicle(string type)
        {
            Vehicle vehicle = new Vehicle();
            if(type == "Caddy")
            {
                vehicle = new VWCaddy();
                return vehicle;
            }

            else if(type == "Passat")
            {
                vehicle = new VWPassat();
                return vehicle;
            }

            else
            {
                throw new ArgumentException("Invalid type");
            }
        }
    }
}
