using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Build a Concrete House: ");
            HouseTemplate houseTemplate = new ConcreteHouse();
            houseTemplate.BuildHouse();

            Console.WriteLine();
            Console.WriteLine("Build a Wooden House: ");
            houseTemplate = new WoodenHouse();
            houseTemplate.BuildHouse();
        }
    }
}
