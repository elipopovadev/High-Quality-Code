using Bridge.BridgeInterface;
using System;

namespace Bridge.Implementation
{
    public class SamsungLedTV : ILedTV
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Samsung TV");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Samsung TV");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Samsung TV");
        }
    }
}
