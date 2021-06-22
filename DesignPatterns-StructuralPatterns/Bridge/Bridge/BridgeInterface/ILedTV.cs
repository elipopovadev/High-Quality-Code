namespace Bridge.BridgeInterface
{
    public interface ILedTV
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int channelNumber);
    }
}
