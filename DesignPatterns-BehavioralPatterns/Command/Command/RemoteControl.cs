using Command.Commands;
using System;
using System.Collections.Generic;

namespace Command
{
   public class RemoteControl
    {
        private Dictionary<string, ICommand> commands;

        public RemoteControl()
        {
            commands = new Dictionary<string, ICommand>();
            commands.Add("1", new LightsCommand());
            commands.Add("2", new TVCommand());
            commands.Add("3", new MusicCommand());
        }

        public void DrawMenu()
        {
            Console.WriteLine("Choose option: ");
            Console.WriteLine("1 - Turn light on");
            Console.WriteLine("1off - Turn light off");
            Console.WriteLine("2 - Turn TV on");
            Console.WriteLine("2off - Turn TV off");
            Console.WriteLine("3 - Turn Music on");
            Console.WriteLine("3off - Turn Music off");
        }     

        public void PerformAction()
        {
            Console.Write("System is waiting for your choice: ");
            string input = Console.ReadLine() ?? string.Empty;
            switch (input)
            {            
                case "1off":
                    TurnLightOff();
                    break;             
                case "2off":
                    TurnTVOff();
                    break;
                case "3off":
                    TurnMusicOff();
                    break;
            }

            if (commands.ContainsKey(input))
            {
                commands[input].Execute();
            }
        }

        private void TurnLightOff()
        {
            Console.WriteLine("Light is off");
        }

        private void TurnTVOff()
        {
            Console.WriteLine("TV is off");
        }

        private void TurnMusicOff()
        {
            Console.WriteLine("Music is off");
        }
    }
}
