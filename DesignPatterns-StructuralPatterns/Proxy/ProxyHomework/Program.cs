using ProxyHomework.ProxyObject;
using System;

namespace ProxyHomework
{
   public class Program
    {
        static void Main(string[] args)
        {
            ATM ATM = new ATM();
            Console.WriteLine(ATM.WithdrawMoney("Ivan Ivanov", 2000));
        }
    }
}
