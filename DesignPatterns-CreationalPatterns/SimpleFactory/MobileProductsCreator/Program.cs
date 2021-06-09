using MobileProductsCreator.Enum;
using MobileProductsCreator.ProductFactory;
using System;

namespace MobileProductsCreator
{
    class Program
    {
        static void Main(string[] args)
        {          
            IMobile firstMobile = SimpleFactory.CreateMobile(MobileType.Nokia);
            IMobile secondMobile = SimpleFactory.CreateMobile(MobileType.Sony);

            Console.WriteLine(firstMobile.Price);
            Console.WriteLine(secondMobile.Price);
        }
    }
}
