using System;

namespace Command.Commands
{
    public class TVCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("TV is on");
        }
    }
}
