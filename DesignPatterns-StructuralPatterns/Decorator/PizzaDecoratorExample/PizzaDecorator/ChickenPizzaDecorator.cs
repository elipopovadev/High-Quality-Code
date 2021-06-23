namespace PizzaDecoratorExample.PizzaDecorator
{
   public class ChickenPizzaDecorator : PizzaDecorator
    {
        public ChickenPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        private string AddChicken()
        {
            return ", Chicken added";
        }
        public override string MakePizza()
        {
            return pizza.MakePizza() + AddChicken();
        }
    }
}
