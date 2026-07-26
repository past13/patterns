using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace Interpreter;

// Handles an XML element: creates a new object whose type matches the element name.
public class ElementCommand : Command
{
    public override void Interpret(Mirror context)
    {
        if (context.Reader.NodeType != XmlNodeType.Element) 
        {
            return;
        }

        Type? type = GetTypeOf(context.Reader.Name);
        if (type == null) 
        {
            return;
        }

        object o = Activator.CreateInstance(type)!;
        if (context.Peek() != null) 
        {
            ((Control)context.Peek()!).Controls.Add((Control)o);
        }

        context.Push(o);
    }

    private static Type? GetTypeOf(string name)
    {
        const string ns = "System.Windows.Forms";
        Assembly asm = typeof(Control).Assembly;
        return asm.GetType($"{ns}.{name}");
    }
}
