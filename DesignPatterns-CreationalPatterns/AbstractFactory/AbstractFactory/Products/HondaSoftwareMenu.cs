namespace AbstractFactory.Products
{
    public class HondaSoftwareMenu : ISoftwareMenu
    {
        public HondaSoftwareMenu(decimal price)
        {
            this.Price = price;
        }

        public decimal Price { get; }
    }
}
