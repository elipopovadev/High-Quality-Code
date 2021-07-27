using System;

namespace State.State
{
    public class DebitCardNotInsertedState : IATMState
    {
        public void EjectDebitCard()
        {
            Console.WriteLine("You cannot eject the Debit CardNo, as no Debit Card in ATM Machine slot");
        }

        public void InsertDebitCard()
        {
            Console.WriteLine("DebitCard Inserted");
        }

        public void EnterPin()
        {
            Console.WriteLine("You cannot enter the pin, as No Debit Card in ATM Machine slot");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("You cannot withdraw money, as No Debit Card in ATM Machine slot");
        }
    }
}
