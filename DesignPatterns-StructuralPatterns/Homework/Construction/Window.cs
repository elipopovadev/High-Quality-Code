namespace FacadeHomework.Construction
{
   public class Window : IConstruction
    {
        public Window()
        {
            this.Price = 50;
        }
        public decimal Price { get; private set; }
    }
}
