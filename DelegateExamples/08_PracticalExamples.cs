namespace DelegateExamples;

/// <summary>
/// Real-world examples of delegate usage.
/// </summary>
public class PracticalExamplesDemo
{
    // Use case 1: Callback pattern
    public class DataProcessor
    {
        public void ProcessData(List<int> data, Action<int> onProgress, Action onComplete)
        {
            for (int i = 0; i < data.Count; i++)
            {
                onProgress(i + 1);
                Thread.Sleep(100);  // Simulate work
            }
            onComplete();
        }
    }

    // Use case 2: Strategy pattern
    public class Calculator
    {
        private Func<int, int, int> strategy;

        public Calculator(string operation)
        {
            strategy = operation switch
            {
                "add" => (a, b) => a + b,
                "subtract" => (a, b) => a - b,
                "multiply" => (a, b) => a * b,
                "divide" => (a, b) => b != 0 ? a / b : throw new DivideByZeroException(),
                _ => throw new ArgumentException("Invalid operation")
            };
        }

        public int Execute(int a, int b) => strategy(a, b);
    }

    public static void Run()
    {
        Console.WriteLine("\n═══════════════════════════════════════════════════════════");
        Console.WriteLine("PRACTICAL USE CASES");
        Console.WriteLine("═══════════════════════════════════════════════════════════\n");

        Example_Callback();
        Example_Strategy();
        Example_LINQ();
    }

    // Use case 1: Callback pattern
    private static void Example_Callback()
    {
        Console.WriteLine("→ Use case 1: Callback pattern (Progress tracking):");
        DataProcessor processor = new();
        List<int> data = new() { 1, 2, 3, 4, 5 };

        processor.ProcessData(
            data,
            progress => Console.WriteLine($"   Processing item {progress}/{data.Count}..."),
            () => Console.WriteLine("   ✓ Done!\n")
        );
    }

    // Use case 2: Strategy pattern
    private static void Example_Strategy()
    {
        Console.WriteLine("→ Use case 2: Strategy pattern (Calculator):");
        
        Calculator addCalc = new("add");
        Console.WriteLine($"   Add: 10 + 5 = {addCalc.Execute(10, 5)}");

        Calculator multiplyCalc = new("multiply");
        Console.WriteLine($"   Multiply: 6 × 7 = {multiplyCalc.Execute(6, 7)}");

        Calculator subtractCalc = new("subtract");
        Console.WriteLine($"   Subtract: 20 - 8 = {subtractCalc.Execute(20, 8)}\n");
    }

    // Use case 3: LINQ with delegates
    private static void Example_LINQ()
    {
        Console.WriteLine("→ Use case 3: LINQ with delegates:");
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Where uses Func<T, bool> (Predicate)
        var evens = numbers.Where(x => x % 2 == 0);

        // Select uses Func<T, TResult>
        var squared = numbers.Select(x => x * x);

        // OrderBy uses Func<T, TKey>
        var sorted = numbers.OrderByDescending(x => x);

        Console.WriteLine($"   All numbers: {string.Join(", ", numbers)}");
        Console.WriteLine($"   Even numbers: {string.Join(", ", evens)}");
        Console.WriteLine($"   Squared: {string.Join(", ", squared)}");
        Console.WriteLine($"   Sorted descending: {string.Join(", ", sorted)}");
        Console.WriteLine();
    }
}

