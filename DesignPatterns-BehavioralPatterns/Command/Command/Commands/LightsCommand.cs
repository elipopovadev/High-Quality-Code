using Command.ControledSystems;

namespace Command.Commands
{
    public class LightsCommand : ICommand
    {
        private readonly Light light;

        public LightsCommand(Light light)
        {
            this.light = light;

        }

        public void Execute()
        {
            light.TurnOn();
        }

        public void Undo()
        {
            light.TurnOff();
        }

        public override string ToString()
        {
            return "Light is turn on";
        }
    }
}
