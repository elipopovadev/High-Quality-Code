using BugattiBuilder.Products;

namespace BugattiBuilder.Builder
{
    public class BugattiChironBuilder : IBuilder
    {
       private Vehicle objectVehicle = new Vehicle();

        public void SetModel()
        {
            objectVehicle.Model = "Chiron"; // create vehicle with CONCRETE model
        }

        public void SetEngine()
        {
            objectVehicle.Engine = "8.0 L (488 cu in) quad-turbocharged W16";
        }

        public void SetTransmission()
        {
            objectVehicle.Transmission = "7-speed dual-clutch automatic";
        }

        public void SetBody()
        {
            objectVehicle.Body = "2-door coupé";
        }

        public void SetAccessories()
        {
            objectVehicle.Accessories.Add("Seat Cover");
            objectVehicle.Accessories.Add("Rear Mirror");
        } 

        public IVehicle GetVehicle()
        {
            return objectVehicle;
        }
    }
}
