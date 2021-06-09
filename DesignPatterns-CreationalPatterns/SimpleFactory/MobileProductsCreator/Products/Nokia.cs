namespace MobileProductsCreator.Products
{
    public class Nokia : IMobile
    {
        public Nokia(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public string Model { get; private set; }
        public decimal Price { get; private set; }
    }
}
