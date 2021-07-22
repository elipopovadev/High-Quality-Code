using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();
            string userInput;

            do
            {
                remote.DrawMenu();
                remote.PerformAction();
                Console.WriteLine("If you want to continue (y):");
                userInput = Console.ReadLine();
            }
            while (userInput == "y");
        }
    }
}
