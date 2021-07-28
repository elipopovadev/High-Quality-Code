using System.Collections.Generic;
using Visitor.Element;
using Visitor.Visitors;

namespace Visitor.ObjectStructure
{
   public class School
    {
        private static readonly List<IElement> elements;
        static School()
        {
            elements = new List<IElement>
            {
                new Kid("Ram"),
                new Kid("Sara"),
                new Kid("Pam")
            };
        }

        public void PerformOperation(IVisitor visitor)
        {
            foreach (var kid in elements)
            {
                kid.Accept(visitor);
            }
        }
    }
}
