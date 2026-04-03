namespace DelegateExamples;

/// <summary>
/// Multicast delegates allow multiple methods to be invoked from one delegate.
/// </summary>
public class MulticastDelegateExamplesDemo
{
    public static void Run()
    {
        Console.WriteLine("\n═══════════════════════════════════════════════════════════");
        Console.WriteLine("MULTICAST DELEGATES");
        Console.WriteLine("═══════════════════════════════════════════════════════════\n");

        Example_Multicast_Action();
        Example_Multicast_Func();
        Example_Multicast_AddRemove();
    }

    // Multicast with Action
    private static void Example_Multicast_Action()
    {
        Console.WriteLine("→ Multicast with Action:");
        Action<string> notify = Console.WriteLine;
        notify += x => Console.WriteLine($"   >> {x}");
        notify += x => Console.WriteLine($"   [LOG] {x}");

        notify("   System startup");
        Console.WriteLine();
    }

    // Multicast with Func (returns last result)
    private static void Example_Multicast_Func()
    {
        Console.WriteLine("→ Multicast with Func (returns last result):");
        Func<int, int> process = x => { Console.WriteLine($"   Step 1: {x}"); return x + 1; };
        process += x => { Console.WriteLine($"   Step 2: {x}"); return x * 2; };
        process += x => { Console.WriteLine($"   Step 3: {x}"); return x + 10; };

        int result = process(5);
        Console.WriteLine($"   Final result: {result}");
        Console.WriteLine();
    }

    // += to add, -= to remove
    private static void Example_Multicast_AddRemove()
    {
        Console.WriteLine("→ Multicast with add (+=) and remove (-=):");
        Action<string> log = x => Console.WriteLine($"   [Console] {x}");
        Action<string> file = x => Console.WriteLine($"   [File] {x}");
        Action<string> network = x => Console.WriteLine($"   [Network] {x}");

        Action<string>? combined = log;
        combined += file;
        combined += network;

        Console.WriteLine("   → With all handlers:");
        combined?.Invoke("Important event");
        
        Console.WriteLine("\n   → After removing file handler:");
        combined -= file;
        combined?.Invoke("Another event");
        Console.WriteLine();
    }
}

