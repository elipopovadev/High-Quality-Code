using PCBuilder.ConcreteBuilder;
using PCBuilder.Products;

namespace PCBuilder.Director
{
    public class PCCreator
    {
        private readonly IBuilder objectBuilder;

        public PCCreator(IBuilder builder)
        {
            objectBuilder = builder;
        }

        public void CreatePC()
        {
            objectBuilder.SetCPU();
            objectBuilder.SetRAM();
            objectBuilder.SetSSD();
            objectBuilder.SetVideoCard();
        }

        public IPC GetPC()
        {
            return objectBuilder.GetPC();
        }
    }
}
