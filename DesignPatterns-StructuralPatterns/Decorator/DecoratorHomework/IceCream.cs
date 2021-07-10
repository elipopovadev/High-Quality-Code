namespace DecoratorHomework
{
   public class IceCream : IIceCream
    {
        public IceCream(double milk, double sugar)
        {
            this.Milk = milk;
            this.Sugar = sugar;
        }

        public double Milk { get; private set; }
        public double Sugar { get; private set; }

        public string MakeIceCream()
        {
            return "IceCream";
        }
    }
}
