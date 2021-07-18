using PCBuilder.Products;

namespace PCBuilder.ConcreteBuilder
{
    public class GamingLenovoBuilder : IBuilder
    {
        private readonly IPC objectPC = new PC();

        public void SetCPU() // void
        {
            objectPC.CPU = "Ryzen 9";
        }

        public void SetRAM() // void
        {
            objectPC.RAM = "16 GB";
        }

        public void SetSSD() // void
        {
            objectPC.SSD = "512 GB";
        }

        public void SetVideoCard() // void
        {
            objectPC.VideoCard = "RTX 3060 Ti";
        }

        public IPC GetPC()
        {
            return objectPC;
        }
    }
}
