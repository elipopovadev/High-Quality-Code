using BugattiBuilder.Builder;
using BugattiBuilder.Director;
using System;

namespace BugattiBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleCreator = new VehicleCreator(new BugattiChironBuilder());
            vehicleCreator.CreateVehicle();
            var vehicle = vehicleCreator.GetVehicle();
            Console.WriteLine(vehicle.Model); // Chiron
        }
    }
}
