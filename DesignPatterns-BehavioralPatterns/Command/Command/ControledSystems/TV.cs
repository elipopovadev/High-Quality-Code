using System;

namespace Command.ControledSystems
{
   public class TV
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is turn on");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is turn off");
            State = State.Off;
        }

        public State State { get; set; }
    }
}
