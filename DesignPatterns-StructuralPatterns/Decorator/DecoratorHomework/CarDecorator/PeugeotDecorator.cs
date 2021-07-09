namespace DecoratorHomework.CarDecorator
{
   public class PeugeotDecorator : CarDecorator
    {
        public PeugeotDecorator(ICar car) : base(car)
        {
        }

        private string AddPeugeotBody()
        {
            return ", PeugeotBody added";
        }

        private string AddPeugeotColour()
        {
            return ", Colour added";
        }

        public override string MakeCar()
        {
            return Car.MakeCar() + this.AddPeugeotBody() + this.AddPeugeotColour();
        }      
    }
}
