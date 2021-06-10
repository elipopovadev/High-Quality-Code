namespace AbstractFactory.Products
{
    public class HondaWindow : IWindow
    {
        public HondaWindow(int size)
        {
            this.Size = size;
        }

        public int Size { get; }
    }
}
