using BugattiBuilder.Builder;
using BugattiBuilder.Products;

namespace BugattiBuilder.Director
{
   public class VehicleCreator
    {
        private readonly IBuilder objectBuilder;

        public VehicleCreator(IBuilder builder)
        {
         objectBuilder = builder;
        }

        public void CreateVehicle()
        {
            objectBuilder.SetModel();
            objectBuilder.SetEngine();
            objectBuilder.SetBody();
            objectBuilder.SetTransmission();
            objectBuilder.SetAccessories();
        }

        public IVehicle GetVehicle()
        {
            return objectBuilder.GetVehicle();
        }
    }
}
