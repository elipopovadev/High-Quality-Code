using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Payment Type : CreditCard or DebitCard or Cash");
            string PaymentType = Console.ReadLine();
            Console.WriteLine("Payment type is : " + PaymentType);

            Console.WriteLine("Please enter Amount to Pay : ");
            decimal Amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Amount is : " + Amount);

            PaymentContext context = new PaymentContext();
            if (PaymentType == "CreditCard")
            {
                context.SetPaymentStrategy(new CreditCardPaymentStrategy());
            }
            else if (PaymentType == "DebitCard")
            {
                context.SetPaymentStrategy(new DebitCardPaymentStrategy());
            }
            else if (PaymentType == "Cash")
            {
                context.SetPaymentStrategy(new CashPaymentStrategy());
            }
            context.Pay(Amount);
        }
    }
}
