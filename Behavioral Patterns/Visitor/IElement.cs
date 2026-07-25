namespace Visitor;

public abstract class IElement
{
    public abstract void Accept(IVisitor visitor);
}
