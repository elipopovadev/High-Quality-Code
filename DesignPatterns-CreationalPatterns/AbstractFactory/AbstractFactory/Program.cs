using AbstractFactory.Factories;
using AbstractFactory.Products;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var hondaFactory = new HondaFactory();
            IDoor frondDoor = hondaFactory.CreateDoor("hondaFrondDoor");
            Console.WriteLine(frondDoor.Color);

            var vwFactory = new VWFactory();
            IWindow vwWindow = vwFactory.CreateWindow();
            Console.WriteLine(vwWindow.Size);
        }
    }
}
