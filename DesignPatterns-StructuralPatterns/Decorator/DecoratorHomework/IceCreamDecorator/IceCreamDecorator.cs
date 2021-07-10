namespace DecoratorHomework.IceCreamDecorator
{
    public abstract class IceCreamDecorator : IIceCream
    {
        protected IIceCream IceCream;

        public IceCreamDecorator(IIceCream iceCream)
        {
            this.IceCream = iceCream;
        }

        public abstract string MakeIceCream();       
    }
}
