using Bridge.BridgeInterface;

namespace Bridge.Abstraction
{
    public abstract class AbstractRemoteControl
    {
        protected ILedTV ledTV;

        public AbstractRemoteControl(ILedTV ledTV)
        {
            this.ledTV = ledTV;
        }

        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}
