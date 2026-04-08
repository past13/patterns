namespace Strategy;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("=== Strategy Pattern: Basic Counter Example ===");
        
        var context = new Context();
        var random = new Random(37);

        // Keep the initial switch from the original example.
        context.SwitchStrategy();

        for (var i = Context.Start; i <= Context.Start + 15; i++)
        {
            if (random.Next(3) == 2)
            {
                Console.Write("|| ");
                context.SwitchStrategy();
            }

            Console.Write($"{context.Algorithm()} ");
        }

        Console.WriteLine();

        // Demonstrate sorting strategies
        SortDemo.DemoMergeSort();
        SortDemo.DemoQuickSort();
    }
}
