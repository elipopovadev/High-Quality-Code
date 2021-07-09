namespace DecoratorHomework.CarDecorator
{
   public class VWDecorator : CarDecorator
    {
        public VWDecorator(ICar car) : base(car)
        {
        }

        private string AddVWBody()
        {
            return ", VWBody added";
        }

        private string AddVWColour()
        {
            return ", Colour added";
        }

        public override string MakeCar()
        {
            return Car.MakeCar() + this.AddVWBody() + this.AddVWColour();              
        }
    }
}
