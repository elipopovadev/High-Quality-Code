namespace FacadeHomework.Construction
{
   public class Roof : IConstruction
    {
        public Roof()
        {
            this.Price = 3000;
        }
        public decimal Price { get; private set; }
    }
}
