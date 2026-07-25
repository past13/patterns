namespace Visitor;

public interface IVisitor
{
    void Visit(Element element);
    void Visit(ElementWithLink element);
}
