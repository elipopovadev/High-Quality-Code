using Command.ControledSystems;
using System;

namespace Command.Commands
{
    public class MusicCommand : ICommand
    {
        private readonly Music music;

        public MusicCommand(Music music)
        {
            this.music = music;
        }
        public void Execute()
        {
            music.TurnOn();
        }

        public void Undo()
        {
            music.TurnOff();
        }

        public override string ToString()
        {
            return "Music is turn on";
        }
    }
}
