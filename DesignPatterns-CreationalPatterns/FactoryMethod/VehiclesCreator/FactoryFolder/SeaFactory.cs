using System;
using VehiclesCreator.Vehicles;

namespace VehiclesCreator.FactoryFolder
{
    public class SeaFactory : IFactoryCreator
    {
        public static IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption)
        {
            IVehicle vehicle = null;
            if(type == "ship")
            {
                vehicle = new Ship(fuelQuantity, fuelConsumption);
            }

            else if(type== "boat")
            {
                vehicle = new Boat(fuelQuantity, fuelConsumption);
            }

            else
            {
                throw new ArgumentException("Invalid vehicle type");
            }

            return vehicle;
        }
    }
}
