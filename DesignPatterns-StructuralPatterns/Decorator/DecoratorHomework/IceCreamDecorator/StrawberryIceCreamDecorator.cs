namespace DecoratorHomework.IceCreamDecorator
{
   public class StrawberryIceCreamDecorator : IceCreamDecorator
    {
        public StrawberryIceCreamDecorator(IIceCream iceCream) : base(iceCream)
        {
        }

        public override string MakeIceCream()
        {
            return IceCream.MakeIceCream() + this.AddNuts() + this.AddTopping();
        }

        private string AddNuts()
        {
            return ", Nuts added";
        }

        private string AddTopping()
        {
            return ", StrawberryTopping added";
        }
    }
}
