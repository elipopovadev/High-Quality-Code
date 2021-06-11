using BugattiBuilder.Products;

namespace BugattiBuilder.Builder
{
   public interface IBuilder
    {
        public void SetModel();
        public void SetEngine();
        public void SetTransmission();
        public void SetBody();
        public void SetAccessories();
        public IVehicle GetVehicle();
    }
}
