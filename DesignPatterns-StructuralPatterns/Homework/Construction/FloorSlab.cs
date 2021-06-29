namespace FacadeHomework.Construction
{
   public class FloorSlab : IConstruction
    {
        public FloorSlab()
        {
            this.Price = 10000;
        }
        public decimal Price { get; private set; }
    }
}
