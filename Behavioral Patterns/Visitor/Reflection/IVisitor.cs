using System.Reflection;

namespace Reflection;

public abstract class IVisitor
{
    public void ReflectiveVisit(Element element)
    {
        Type[] types = new Type[] { element.GetType() };
        MethodInfo? methodInfo = GetType().GetMethod("Visit", types);
        methodInfo?.Invoke(this, new object[] { element });
    }
}
