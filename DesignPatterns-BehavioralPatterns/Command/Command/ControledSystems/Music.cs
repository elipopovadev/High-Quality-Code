using System;

namespace Command.ControledSystems
{
   public class Music
    {
        public void TurnOn()
        {
            Console.WriteLine("Music is turn on");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Music is turn off");
            State = State.Off;
        }

        public State State { get; set; }
    }
}
