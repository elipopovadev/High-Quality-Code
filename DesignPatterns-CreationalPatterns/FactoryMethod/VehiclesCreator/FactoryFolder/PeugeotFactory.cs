using System;
using VehiclesCreator.Vehicles;

namespace VehiclesCreator.FactoryFolder
{
    public class PeugeotFactory : VehicleFactory
    {
        protected override Vehicle MakeVehicle(string type)
        {
            Vehicle vehicle = new Vehicle();
            if (type == "207")
            {
                vehicle = new Peugeot207();
                return vehicle;
            }

            else if (type == "308")
            {
                vehicle = new Peugeot308();
                return vehicle;
            }

            else
            {
                throw new ArgumentException("Invalid type");
            }
        }
    }
}
