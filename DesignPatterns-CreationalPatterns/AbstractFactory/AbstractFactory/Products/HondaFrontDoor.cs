namespace AbstractFactory.Products
{
    public class HondaFrontDoor : IDoor
    {
        public HondaFrontDoor(string color, int size)
        {
            this.Color = color;
            this.Size = size;
        }

        public string Color { get; private set; }
        public int Size { get; private set; }
    }
}
