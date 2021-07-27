using System;

namespace State.State
{
    public class DebitCardInsertedState : IATMState
    {
        public void InsertDebitCard()
        {
            Console.WriteLine("You cannot insert the Debit Card, as the Debit card is already there ");
        }

        public void EjectDebitCard()
        {
            Console.WriteLine("Debit Card is ejected");
        }

        public void EnterPin()
        {
            Console.WriteLine("Pin number has been entered correctly");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Money has been withdrawn");
        }
    }
}
