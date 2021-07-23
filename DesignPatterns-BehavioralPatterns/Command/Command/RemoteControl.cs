using Command.Commands;
using System.Collections.Generic;
using System.Text;

namespace Command
{
   public class RemoteControl
    {
        private Dictionary<int, ICommand> commands;

        public RemoteControl()
        {
            commands = new Dictionary<int, ICommand>();
        }

        public void SetCommandForButton(int buttonID, ICommand cmd) // set commands
        {
            commands[buttonID] = cmd;
        }

        public override string ToString() // draw menu
        {
            var sb = new StringBuilder();
            foreach (var buttonID in commands.Keys)
            {
                sb.AppendLine($"{buttonID} - {commands[buttonID]}");
            }

            return sb.ToString();
        }

        public void PushButton(int buttonID) // push button
        {
            if (commands.ContainsKey(buttonID))
            {
                commands[buttonID].Execute();
            }
        }

        public void UndoButton(int buttonID) // undo button
        {
            if (commands.ContainsKey(buttonID))
            {
                commands[buttonID].Undo();
            }
        }
    }
}
