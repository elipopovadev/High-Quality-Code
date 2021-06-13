using System;
using VehiclesCreator.FactoryFolder;
using VehiclesCreator.Vehicles;

namespace VehiclesCreator
{
   public class Program
    {
        static void Main(string[] args)
        {
            IVehicle firstVehicle = new CaddyFactory().CreateVehicle(); // the subclass is CaddyFactory and decided to create VW Caddy
            if(firstVehicle!= null)
            {
                Console.WriteLine(firstVehicle.FuelConsumption);
            }

            else
            {
                Console.WriteLine("Invalid Vehicle type");
            }

            IVehicle secondVehicle = new PassatFactory().CreateVehicle();
            if (secondVehicle != null)
            {
                Console.WriteLine(secondVehicle.FuelQuantity);
            }

            else
            {
                Console.WriteLine("Invalid Vehicle type");
            }
        }
    }
}
