using Memento.Memento;

namespace Memento
{
   public class Originator
    {
        public LEDTV ledTV;

        public Memento.Memento CreateMemento()
        {
            return new Memento.Memento(ledTV);
        }

        public void SetMemento(Memento.Memento memento)
        {
            ledTV = memento.ledTV;
        }

        public string GetDetails()
        {
            return "Originator [ledTV=" + ledTV.GetDetails() + "]";
        }
    }
}
