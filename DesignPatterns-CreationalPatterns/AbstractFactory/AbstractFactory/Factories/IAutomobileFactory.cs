using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
   public interface IAutomobileFactory
    {
        public IDoor CreateDoor(string door);
        public IWindow CreateWindow();
        public ISoftwareMenu CreateSoftwareMenu();
    }
}
