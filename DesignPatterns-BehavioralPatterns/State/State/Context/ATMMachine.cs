using State.State;
using System;

namespace State.Context
{
    public class ATMMachine : IATMState
    {
        public IATMState atmMachineState { get;private set; } // variable to hold the Concrete State object

        public ATMMachine()
        {
            atmMachineState = new DebitCardNotInsertedState(); // initially the State of the ATM Machine is DebitCardNotInsertedState 
        }

        public void InsertDebitCard()
        {
            atmMachineState.InsertDebitCard();
            // Debit Card has been inserted so internal state of ATM Machine
            // has been changed to 'DebitCardNotInsertedState'

            if (atmMachineState is DebitCardNotInsertedState)
            {
                atmMachineState = new DebitCardInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                + atmMachineState.GetType().Name);
            }
        }

        public void EjectDebitCard()
        {
            atmMachineState.EjectDebitCard();
            // Debit Card has been ejected so internal state of ATM Machine
            // has been changed to 'DebitCardNotInsertedState'

            if (atmMachineState is DebitCardInsertedState)
            {
                atmMachineState = new DebitCardNotInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                + atmMachineState.GetType().Name);
            }
        }

        public void EnterPin()
        {
            atmMachineState.EnterPin();
        }
     
        public void WithdrawMoney()
        {
            atmMachineState.WithdrawMoney();
        }
    }
}
