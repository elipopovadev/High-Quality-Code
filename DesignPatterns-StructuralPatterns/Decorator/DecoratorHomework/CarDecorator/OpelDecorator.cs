namespace DecoratorHomework.CarDecorator
{
   public class OpelDecorator : CarDecorator
    {
        public OpelDecorator(ICar car) : base(car)
        {
        }

        private string AddOpelBody()
        {
            return ", OpelBody added";
        }

        private string AddOpelColour()
        {
            return ", Colour added";
        }

        public override string MakeCar()
        {
            return Car.MakeCar() + this.AddOpelBody() + this.AddOpelColour();
        }
    }
}
