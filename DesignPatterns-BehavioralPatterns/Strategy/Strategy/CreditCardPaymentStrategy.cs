using System;

namespace Strategy
{
   public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " using Credit Card");
        }
    }
}
