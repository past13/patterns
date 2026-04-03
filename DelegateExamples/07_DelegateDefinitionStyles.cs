namespace DelegateExamples;

/// <summary>
/// Comparison of three ways to define delegates.
/// </summary>
public class DelegateDefinitionStylesDemo
{
    public static void Run()
    {
        Console.WriteLine("\n═══════════════════════════════════════════════════════════");
        Console.WriteLine("DELEGATE DEFINITION STYLES");
        Console.WriteLine("═══════════════════════════════════════════════════════════\n");

        Style_Lambda();
        Style_NamedMethod();
        Style_AnonymousMethod();

        Console.WriteLine("→ Recommendation: Use lambda expressions for simplicity and readability\n");
    }

    // Style 1: Lambda expression (modern, concise)
    private static void Style_Lambda()
    {
        Console.WriteLine("→ Style 1: Lambda expression (modern, concise):");
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine($"   Result: {add(3, 4)}");
        Console.WriteLine();
    }

    // Style 2: Named method (traditional, reusable)
    private static void Style_NamedMethod()
    {
        Console.WriteLine("→ Style 2: Named method (traditional, reusable):");
        Func<int, int, int> add = AddNumbers;
        Console.WriteLine($"   Result: {add(3, 4)}");
        Console.WriteLine();

        static int AddNumbers(int a, int b) => a + b;
    }

    // Style 3: Anonymous method (older syntax, verbose)
    private static void Style_AnonymousMethod()
    {
        Console.WriteLine("→ Style 3: Anonymous method (older syntax, verbose):");
        Func<int, int, int> add = delegate (int a, int b)
        {
            return a + b;
        };
        Console.WriteLine($"   Result: {add(3, 4)}");
        Console.WriteLine();
    }
}

