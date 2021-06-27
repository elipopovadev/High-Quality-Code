using System;
using Flyweight.ConcreteFlyweight;
using Flyweight.FlyweightInterface;
using System.Collections.Generic;

namespace Flyweight.FlyweightFactory
{
    public static class ShapeFactory
    {
        // dictionary collection object which will act as a cache for our application
        private static Dictionary<string, IShape> shapeDictionary = new Dictionary<string, IShape>();

        public static IShape GetShape(string shapeType)
        {
            IShape shape = null;

            if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                if (shapeDictionary.ContainsKey("circle"))
                {
                    return shapeDictionary[shapeType];
                }

                else
                {
                    shape = new Circle();
                    shapeDictionary.Add("circle", shape); // Creating circle object without any color                 
                }
            }

            else if (shape == null)
            {
                throw new ArgumentException("The shape can not be null");
            }

            return shape;
        }
    }
}
