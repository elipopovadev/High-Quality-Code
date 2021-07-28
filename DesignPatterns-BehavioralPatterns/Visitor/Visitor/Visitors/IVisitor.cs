using Visitor.Element;

namespace Visitor.Visitors
{
   public interface IVisitor
    {
        void Visit(IElement element);
    }
}
