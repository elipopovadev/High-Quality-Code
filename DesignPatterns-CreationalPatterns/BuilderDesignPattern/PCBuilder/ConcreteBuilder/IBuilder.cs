using PCBuilder.Products;

namespace PCBuilder.ConcreteBuilder
{
   public interface IBuilder
    {
        public void SetSSD();
        public void SetCPU();
        public void SetRAM();
        public void SetVideoCard();
        public IPC GetPC();
    }
}
