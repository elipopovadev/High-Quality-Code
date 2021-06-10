namespace AbstractFactory.Products
{
    public class HondaBackDoor : IDoor
    {
        public HondaBackDoor(string color, int size, string shape)
        {
            this.Color = color;
            this.Size = size;
            this.Shape = shape;
        }

        public string Color { get; private set; }
        public int Size { get; private set; }
        public string Shape { get; private set; }
    }
}
