using System;

namespace Command.ControledSystems
{
    public enum State
    {
        Off = 0,
        On = 1
    }
   public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is turn on");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is turn off");
           State = State.Off;
        }

        public State State { get; set; }
    }
}
