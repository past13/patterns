using System.Collections;
using System.Xml;

namespace Interpreter;

// A general-purpose interpreter for any .NET API.
// Reads XML and instantiates/configures the objects it represents.
public class Mirror
{
    private readonly Stack objectStack;
    private readonly List<Command> commands;

    public XmlTextReader Reader { get; set; }
    public object? LastObject { get; set; }
    public object? CurrentObject => objectStack.Peek();

    public Mirror(string spec)
    {
        objectStack = new Stack();
        objectStack.Push(null);

        commands = new List<Command>
        {
            new ElementCommand(),
            new EndElementCommand(),
            new AttributeCommand()
        };

        Reader = new XmlTextReader(spec);
        while (Reader.Read())
        {
            InterpretCommands();

            bool isEmpty = Reader.IsEmptyElement;
            if (Reader.HasAttributes)
            {
                for (int i = 0; i < Reader.AttributeCount; i++)
                {
                    Reader.MoveToAttribute(i);
                    InterpretCommands();
                }
            }

            if (isEmpty) 
            {
                Pop();
            }
        }
    }

    public void InterpretCommands()
    {
        foreach (Command c in commands)
        {
            c.Interpret(this);
        }
    }

    public void Push(object o) => objectStack.Push(o);
    public void Pop() => LastObject = objectStack.Pop();
    public object? Peek() => objectStack.Peek();
}
