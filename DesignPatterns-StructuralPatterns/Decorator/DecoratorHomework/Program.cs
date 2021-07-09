using DecoratorHomework.CarDecorator;
using System;

namespace DecoratorHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar carObj = new Car(50, 10);
            string car = carObj.MakeCar();
            Console.WriteLine(car);

            OpelDecorator opelDecorator = new OpelDecorator(carObj);
            string opel = opelDecorator.MakeCar();
            Console.WriteLine(opel);

            PeugeotDecorator peugeotDecorator = new PeugeotDecorator(carObj);
            string peugeot = peugeotDecorator.MakeCar();
            Console.WriteLine(peugeot);
        }
    }
}
