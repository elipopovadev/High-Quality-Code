using System;
using VehiclesCreator.FactoryFolder;
using VehiclesCreator.Vehicles;

namespace VehiclesCreator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle vwCaddy = new VWFactory().CreateVehicle("Caddy"); // the subclass is VWFactory and decided to create VW Caddy
            Console.WriteLine(vwCaddy.FuelConsumption);

            Vehicle peugeot308 = new PeugeotFactory().CreateVehicle("207");
            Console.WriteLine(peugeot308.FuelQuantity);
        }
    }
}
