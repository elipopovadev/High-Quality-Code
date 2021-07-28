using System;
using Visitor.Element;

namespace Visitor.Visitors
{
    public class Salesman : IVisitor
    {
        public Salesman(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Salesman: " + this.Name + " gave the school bag to the child: "
                            + kid.KidName);
        }
    }
}
