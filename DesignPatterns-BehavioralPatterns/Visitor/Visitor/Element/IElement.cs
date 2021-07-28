using Visitor.Visitors;

namespace Visitor.Element
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
