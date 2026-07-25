namespace Visitor;

public class CountVisitor : IVisitor
{
    public int Count { get; private set; }

    // Elements with links are not counted
    public void Visit(ElementWithLink element)
    {
        Console.WriteLine("Not counting");
    }

    // Only plain Elements are counted
    public void Visit(Element element)
    {
        Count++;
    }
}
