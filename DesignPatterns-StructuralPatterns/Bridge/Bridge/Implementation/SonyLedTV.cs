using Bridge.BridgeInterface;
using System;

namespace Bridge.Implementation
{
    public class SonyLedTV : ILedTV
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Sony TV");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Sony TV");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Sony TV");
        }
    }
}
