using Decorator.CarDecorator;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar bmw1 = new BMW();
            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmw1);
            carWithDieselEngine.ManufactureCar();

            ICar bmw2 = new BMW();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmw2);
            carWithPetrolEngine.ManufactureCar();
        }
    }
}
