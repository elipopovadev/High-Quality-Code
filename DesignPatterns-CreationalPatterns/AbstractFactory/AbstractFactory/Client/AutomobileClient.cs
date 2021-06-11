using AbstractFactory.Factories;
using AbstractFactory.Products;
using System;

namespace AbstractFactory.Client
{
    public class AutomobileClient
    {
        private readonly IDoor backDoor;
        private readonly IDoor frondDoor;
        private readonly IWindow window;
        private readonly ISoftwareMenu softwareMenu;

        public AutomobileClient(IAutomobileFactory factory, string type)
        {
            switch (type)
            {
                case "backDoor":
                    {
                        backDoor = factory.CreateDoor(type);
                        break;
                    }

                case "frondDoor":
                    {
                        frondDoor = factory.CreateDoor(type);
                        break;
                    }

                case "window":
                    {
                        window = factory.CreateWindow();
                        break;
                    }

                case "softwareMenu":
                    {
                        softwareMenu = factory.CreateSoftwareMenu();
                        break;
                    }

                default:
                    throw new ArgumentException("Invalid type");
            }
        }

        public IDoor GetBackDoor()
        {
            return backDoor;
        }

        public IDoor GetFrondDoor()
        {
            return frondDoor;
        }

        public IWindow GetWindow()
        {
            return window;
        }

        public ISoftwareMenu GetSoftwareMenu()
        {
            return softwareMenu;
        }
    }
}
