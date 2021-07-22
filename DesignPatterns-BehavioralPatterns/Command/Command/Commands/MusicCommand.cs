using System;

namespace Command.Commands
{
    public class MusicCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Music is on");
        }
    }
}
