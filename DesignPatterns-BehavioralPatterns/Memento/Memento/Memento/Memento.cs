namespace Memento.Memento
{
   public class Memento
    {       
        public Memento(LEDTV ledTV)
        {
            this.ledTV = ledTV;
        }

        public LEDTV ledTV { get; set; }
        public string GetDetails()
        {
            return "Memento [ledTV=" + ledTV.GetDetails() + "]";
        }
    }
}
