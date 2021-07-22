using System;

namespace Command.Commands
{
    public class LightsCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Light is on");
        }
    }
}
