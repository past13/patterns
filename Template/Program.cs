namespace Template;

internal static class Program
{
    private static void Main()
    {
        var algorithm = new Algorithm();

        algorithm.TemplateMethod(new ClassA());
        algorithm.TemplateMethod(new ClassB());
    }
}
