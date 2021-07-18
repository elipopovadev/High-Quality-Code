using PCBuilder.ConcreteBuilder;
using PCBuilder.Director;
using PCBuilder.Products;
using System;

namespace PCBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var PCCreator = new PCCreator(new GamingLenovoBuilder());
            PCCreator.CreatePC();
            IPC pc = PCCreator.GetPC();
            Console.WriteLine(pc.CPU); // Ryzen 9
        }
    }
}
