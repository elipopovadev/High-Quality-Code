﻿namespace VehiclesCreator.Vehicles
{
   public class Ship : IVehicle
    {
        public Ship(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; private set; }
        public double FuelConsumption { get; private set; }
    }
}
