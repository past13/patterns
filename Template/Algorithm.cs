namespace Template;

internal sealed class Algorithm
{
    public void TemplateMethod(IPrimitives primitives)
    {
        var output = primitives.Operation1() + primitives.Operation2();
        Console.WriteLine(output);
    }
}

