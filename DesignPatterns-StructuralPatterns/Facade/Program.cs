using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.PlaceOrder();
        }
    }
}
