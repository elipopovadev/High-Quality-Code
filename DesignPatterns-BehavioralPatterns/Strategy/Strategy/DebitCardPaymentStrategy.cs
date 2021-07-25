using System;

namespace Strategy
{
   public class DebitCardPaymentStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " using Debit Card");
        }
    }
}
