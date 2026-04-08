namespace State;

internal static class Program
{
    private static void Main()
    {
        var context = new Context(new NormalState());
        var random = new Random(37);

        for (var i = 5; i <= 25; i++)
        {
            var command = random.Next(3);
            Console.Write($"{context.Request(command)} ");
        }

        Console.WriteLine();
    }
}
