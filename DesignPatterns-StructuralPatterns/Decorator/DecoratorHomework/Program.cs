using DecoratorHomework.IceCreamDecorator;
using System;

namespace DecoratorHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            IIceCream iceCreamObj = new IceCream(1,0.2d);
            string iceCream = iceCreamObj.MakeIceCream();
            Console.WriteLine(iceCream);

            BananaIceCreamDecorator bananaIceCreamDecorator = new BananaIceCreamDecorator(iceCreamObj);
            string iceCream2 = bananaIceCreamDecorator.MakeIceCream();
            Console.WriteLine(iceCream2);

            StrawberryIceCreamDecorator strawberryIceCreamDecorator = new StrawberryIceCreamDecorator(iceCreamObj);
            string iceCream3 = strawberryIceCreamDecorator.MakeIceCream();
            Console.WriteLine(iceCream3);
        }
    }
}
