using Bridge.BridgeInterface;

namespace Bridge.Abstraction
{
   public class SamsungRemoteControl : AbstractRemoteControl
    {
        public SamsungRemoteControl(ILedTV ledTV) : base(ledTV)
        {
        }
        public override void SwitchOn()
        {
            ledTV.SwitchOn();
        }

        public override void SwitchOff()
        {
            ledTV.SwitchOff();
        }

        public override void SetChannel(int channelNumber)
        {
            ledTV.SetChannel(channelNumber);
        }
    }
}
