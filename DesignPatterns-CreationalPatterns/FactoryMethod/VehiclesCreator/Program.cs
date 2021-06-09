using System;
using VehiclesCreator.FactoryFolder;
using VehiclesCreator.Vehicles;

namespace VehiclesCreator
{
   public class Program
    {
        static void Main(string[] args)
        {
            IVehicle firstVehicle = RoadFactory.CreateVehicle("car", 50, 10);
            Console.WriteLine(firstVehicle.FuelConsumption);

            IVehicle secondVehicle = SeaFactory.CreateVehicle("ship", 100, 20);
            Console.WriteLine(secondVehicle.FuelConsumption);
        }
    }
}
