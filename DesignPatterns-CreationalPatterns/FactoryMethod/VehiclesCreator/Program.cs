using System;
using VehiclesCreator.FactoryFolder;
using VehiclesCreator.Vehicles;

namespace VehiclesCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle firstVehicle = Factory.CreateVehicle("car", 50, 10);
            Console.WriteLine(firstVehicle.FuelConsumption);

            IVehicle secondVehicle = Factory.CreateVehicle("truck", 100, 20);
            Console.WriteLine(secondVehicle.FuelConsumption);
        }
    }
}
