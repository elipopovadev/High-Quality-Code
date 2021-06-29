namespace FacadeHomework.Construction
{
   public class Wall : IConstruction
    {
        public Wall()
        {
            this.Price = 250;
        }
        public decimal Price { get; private set; }
    }
}
