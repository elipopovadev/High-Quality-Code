namespace AbstractFactory.Products
{
    public class VWWindow : IWindow
    {
        public VWWindow(int size)
        {
            this.Size = size;
        }

        public int Size { get; }
    }
}
