using System;
using VehiclesCreator.Vehicles;

namespace VehiclesCreator.FactoryFolder
{
   public class RoadFactory : IFactoryCreator
    {
        public static IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption)
        {
            IVehicle vehicle = null;
            if (type == "car")
            {
                vehicle = new Car(fuelQuantity, fuelConsumption);
            }

            else if (type == "truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption);
            }

            else
            {
                throw new ArgumentException("Invalid vehicle type");
            }

            return vehicle;
        }
    }
}
