using Visitor.Visitors;

namespace Visitor.Element
{
    public class Kid : IElement
    {
        public Kid(string name)
        {
            this.KidName = name;
        }

        public string KidName { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

       
    }
}
