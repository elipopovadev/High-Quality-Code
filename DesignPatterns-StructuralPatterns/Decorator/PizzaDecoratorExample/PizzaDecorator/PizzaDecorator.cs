namespace PizzaDecoratorExample.PizzaDecorator
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza pizza;

        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }
        public abstract string MakePizza();
    }
}
