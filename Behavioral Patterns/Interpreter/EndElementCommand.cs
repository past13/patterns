using System.Xml;

namespace Interpreter;

// Handles an XML end element: pops the current object off the stack.
public class EndElementCommand : Command
{
    public override void Interpret(Mirror context)
    {
        if (context.Reader.NodeType != XmlNodeType.EndElement) 
        {
            return;
        }
        
        context.Pop();
    }
}
