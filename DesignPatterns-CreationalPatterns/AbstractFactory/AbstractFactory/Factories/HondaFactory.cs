using AbstractFactory.Products;
using System;

namespace AbstractFactory.Factories
{
    public class HondaFactory : IAutomobileFactory
    {
        public IDoor CreateDoor(string door)
        {
            switch (door)
            {
                case "frontDoor":
                    return new HondaFrontDoor("white", 50);
                case "backDoor":
                    return new HondaBackDoor("white", 90, "circle");
                default:
                    throw new ArgumentException("Invalid type of door");
            }
        }

        public ISoftwareMenu CreateSoftwareMenu()
        {
            return new HondaSoftwareMenu(800);
        }

        public IWindow CreateWindow()
        {
            return new HondaWindow(40);
        }
    }
}
