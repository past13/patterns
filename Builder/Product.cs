namespace Builder;

internal sealed class Product
{
    private readonly List<string> _parts = new();

    public void Add(string part) => _parts.Add(part);

    public void Display()
    {
        Console.WriteLine("\nProduct Parts -------");
        Console.WriteLine(string.Join(" ", _parts));
    }
}