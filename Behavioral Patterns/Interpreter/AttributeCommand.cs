using System.Reflection;
using System.Xml;

namespace Interpreter;

// Applies XML attributes to the current object by reflecting to its properties.
public class AttributeCommand : Command
{
    public override void Interpret(Mirror context)
    {
        if (context.Reader.NodeType != XmlNodeType.Attribute) 
        {
            return;
        }

        SetProperty(context.Peek()!, context.Reader.Name, context.Reader.Value);
    }

    private static void SetProperty(object o, string name, string val)
    {
        Type type = o.GetType();
        PropertyInfo? property = type.GetProperty(name);
        if (property == null) 
        {
            return;
        }

        if (property.PropertyType.IsAssignableFrom(typeof(string)))
        {
            property.SetValue(o, val);
        }
        else if (property.PropertyType.IsSubclassOf(typeof(Enum)))
        {
            object ev = Enum.Parse(property.PropertyType, val, ignoreCase: true);
            property.SetValue(o, ev);
        }
        else
        {
            MethodInfo? m = property.PropertyType.GetMethod("Parse", new[] { typeof(string) });
            object? newval = m?.Invoke(null, new object[] { val });
            property.SetValue(o, newval);
        }
    }
}
