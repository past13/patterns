namespace DelegateExamples;

/// <summary>
/// Predicate<T> is a specialized delegate for boolean conditions.
/// Equivalent to Func<T, bool>.
/// </summary>
public class PredicateExamplesDemo
{
    public static void Run()
    {
        Console.WriteLine("\n═══════════════════════════════════════════════════════════");
        Console.WriteLine("PREDICATE DELEGATES");
        Console.WriteLine("═══════════════════════════════════════════════════════════\n");

        Example_Predicate_Numbers();
        Example_Predicate_WithList();
        Example_Predicate_String();
    }

    // Predicate for filtering numbers
    private static void Example_Predicate_Numbers()
    {
        Console.WriteLine("→ Predicate for filtering numbers:");
        Predicate<int> isEven = num => num % 2 == 0;
        Predicate<int> isPositive = num => num > 0;

        Console.WriteLine($"   isEven(4) = {isEven(4)}");
        Console.WriteLine($"   isEven(5) = {isEven(5)}");
        Console.WriteLine($"   isPositive(-5) = {isPositive(-5)}");
        Console.WriteLine($"   isPositive(5) = {isPositive(5)}");
        Console.WriteLine();
    }

    // Predicate with List.FindAll
    private static void Example_Predicate_WithList()
    {
        Console.WriteLine("→ Predicate with List.FindAll:");
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        Predicate<int> isEven = x => x % 2 == 0;
        List<int> evenNumbers = numbers.FindAll(isEven);
        
        Console.WriteLine($"   Numbers: {string.Join(", ", numbers)}");
        Console.WriteLine($"   Even numbers: {string.Join(", ", evenNumbers)}");
        Console.WriteLine();
    }

    // Predicate for string validation
    private static void Example_Predicate_String()
    {
        Console.WriteLine("→ Predicate for string validation:");
        Predicate<string> isLongString = s => s.Length > 5;
        Predicate<string> startsWithA = s => s.StartsWith("A");

        Console.WriteLine($"   isLongString(\"Hello\") = {isLongString("Hello")}");
        Console.WriteLine($"   isLongString(\"HelloWorld\") = {isLongString("HelloWorld")}");
        Console.WriteLine($"   startsWithA(\"Apple\") = {startsWithA("Apple")}");
        Console.WriteLine($"   startsWithA(\"Banana\") = {startsWithA("Banana")}");
        Console.WriteLine();
    }
}

