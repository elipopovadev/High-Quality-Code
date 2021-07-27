using State.Context;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initially ATM Machine in DebitCardNotInsertedState
            ATMMachine atmMachine = new ATMMachine();
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.EjectDebitCard();
            atmMachine.InsertDebitCard();
            Console.WriteLine();
            // Debit Card has been inserted so internal state of ATM Machine
            // has been changed to DebitCardInsertedState
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.InsertDebitCard();
            atmMachine.EjectDebitCard();
            Console.WriteLine("");
            // Debit Card has been ejected so internal state of ATM Machine
            // has been changed to DebitCardNotInsertedState
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
        }
    }
}
