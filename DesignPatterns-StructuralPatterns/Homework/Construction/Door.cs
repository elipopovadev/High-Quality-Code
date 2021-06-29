namespace FacadeHomework.Construction
{
   public class Door : IConstruction
    {
        public Door()
        {
            this.Price = 300;
        }
        public decimal Price { get; private set; }
    }
}
