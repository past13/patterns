namespace Reflection;

public class PrintVisitor : IVisitor
{
    public void Print(Element element)
    {
        ReflectiveVisit(element);

        if (element.Part != null)
        {
            Console.Write(" [");
            Print(element.Part);
        }

        if (element.Next != null) 
        {
            Print(element.Next);
        }

        Console.Write("] ");
    }

    public void Visit(Element element)
    {
        Console.Write(" " + element.Weight);
    }
}
