namespace Visitor;

public class Element : IElement
{
    public Element? Next { get; set; }
    public Element? Link { get; set; }

    public Element() { }

    public Element(Element? next)
    {
        Next = next;
    }

    public virtual void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        AcceptChildren(visitor);
    }

    protected void AcceptChildren(IVisitor visitor)
    {
        Link?.Accept(visitor);
        Next?.Accept(visitor);
    }
}
