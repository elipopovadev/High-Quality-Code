using System;

namespace Strategy
{
    public class CashPaymentStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " By Cash");
        }
    }
}
