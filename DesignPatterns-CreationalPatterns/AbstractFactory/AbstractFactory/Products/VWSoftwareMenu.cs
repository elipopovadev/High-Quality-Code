namespace AbstractFactory.Products
{
   public class VWSoftwareMenu : ISoftwareMenu
    {
        public VWSoftwareMenu(decimal price)
        {
            this.Price = price;
        }

        public decimal Price { get; }
    }
}
