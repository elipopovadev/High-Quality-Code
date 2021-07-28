using System;
using Visitor.Element;

namespace Visitor.Visitors
{
   public class Doctor : IVisitor
    {     
        public Doctor(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Doctor: " + this.Name + " did the health checkup of the child: " + kid.KidName);
        }
    }
}
