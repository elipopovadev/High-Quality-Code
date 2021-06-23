namespace PizzaDecoratorExample.PizzaDecorator
{
    public class VegPizzaDecorator : PizzaDecorator
    {
        public VegPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        private string AddVegetables()
        {
            return ", Vegetables added";
        }

        public override string MakePizza()
        {
            return pizza.MakePizza() + AddVegetables();
        }
    }
}
