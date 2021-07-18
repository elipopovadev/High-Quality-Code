using AbstractFactory.Products;
using System;

namespace AbstractFactory.Factories
{
    public class VWFactory : IAutomobileFactory
    {
        public IDoor CreateDoor(string door)
        {
            switch (door)
            {
                case "frontDoor":
                    return new HondaFrontDoor("red", 50);
                case "backDoor":
                    return new HondaBackDoor("red", 90, "rectangle");
                default:
                    throw new ArgumentException("Invalid type of door");
            }
        }

        public ISoftwareMenu CreateSoftwareMenu()
        {
            return new VWSoftwareMenu(950);
        }

        public IWindow CreateWindow()
        {
            return new VWWindow(10);
        }
    }
}
