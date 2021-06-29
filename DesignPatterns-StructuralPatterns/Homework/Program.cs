using FacadeHomework.CreatingFacade;
using System;

namespace FacadeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            House newHouse = new House(7, 6);
            decimal price = newHouse.CalculatePrice();
            Console.WriteLine($"Price is: {price}$");
            newHouse.MakePayment();
        }
    }
}
