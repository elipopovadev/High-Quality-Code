using Command.Commands;
using Command.ControledSystems;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();
            string userInput;

            // Set commands
            remote.SetCommandForButton(1, new LightsCommand(new Light()));
            remote.SetCommandForButton(2, new TVCommand(new TV()));
            remote.SetCommandForButton(3, new MusicCommand(new Music()));

            do
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine(remote.ToString()); // draw menu

                Console.Write("The system is waiting for your choice: ");
                var input = Console.ReadLine();
                int buttonID;
                int.TryParse(input, out buttonID);
                remote.PushButton(buttonID); // push button
                remote.UndoButton(buttonID); // undo button

                Console.Write("If you want to continue press (y): ");
                userInput = Console.ReadLine();
            }
            while (userInput == "y");
        }
    }
}
