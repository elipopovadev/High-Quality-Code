namespace DecoratorHomework.IceCreamDecorator
{
   public class BananaIceCreamDecorator : IceCreamDecorator
    {
        public BananaIceCreamDecorator(IIceCream iceCream) : base(iceCream)
        {
        }

        public override string MakeIceCream()
        {
            return IceCream.MakeIceCream() + this.AddCoconut() + this.AddTopping();
        }

        private string AddCoconut()
        {
            return ", Coconut added";
        }

        private string AddTopping()
        {
            return ", BananaTopping added";
        }      
    }
}
