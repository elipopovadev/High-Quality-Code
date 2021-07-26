namespace Observer.Observer
{
   public interface IObserver
    {
        void SendMessageToObserver(string availability);
        string GetName();
    }
}
