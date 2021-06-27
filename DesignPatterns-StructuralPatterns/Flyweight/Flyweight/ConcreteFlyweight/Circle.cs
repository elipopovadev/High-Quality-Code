using Flyweight.FlyweightInterface;
using System;

namespace Flyweight.ConcreteFlyweight
{
    public class Circle : IShape
    {
        private int XCor = 10;
        private int YCor = 20;
        private int Radius = 30;

        public void SetColor(string Color)
        {
            this.Color = Color;
        }

        public string Color { get; set; }

        public void Draw()
        {
            Console.WriteLine(" Circle: Draw() Color : " + this.Color + ", X Cor : " + this.XCor + ", YCor :" + this.YCor + ", Radius :"
        + this.Radius);
        }
    }
}
