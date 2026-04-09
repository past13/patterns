namespace ChainOfResponsibility.FirstExample;

public static class HandleFirstExample
{
    public static void Run()
    {
        Handler? start = null;

        for (var i = 5; i > 0; i--)
        {
            Console.WriteLine($"Handler {i} deals up to a limit of {i * 1000}");
            start = new Handler(i, start);
        }

        if (start is null)
        {
            return;
        }

        int[] requests = [50, 2000, 1500, 10000, 175, 4500];

        Console.WriteLine();
        foreach (var request in requests)
        {
            Console.WriteLine(start.HandleRequest(request));
        }
    }
}