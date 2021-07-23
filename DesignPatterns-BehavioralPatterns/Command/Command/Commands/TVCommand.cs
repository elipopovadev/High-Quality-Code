using Command.ControledSystems;

namespace Command.Commands
{
    public class TVCommand : ICommand
    {
        private readonly TV tv;

        public TVCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.TurnOn();
        }

        public void Undo()
        {
            tv.TurnOff();
        }

        public override string ToString()
        {
            return "TV is turn on";
        }
    }
}
