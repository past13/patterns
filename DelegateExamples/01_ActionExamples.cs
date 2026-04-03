namespace DelegateExamples;

/// <summary>
/// Action delegates represent methods that return void.
/// They can have 0 to 16 parameters.
/// </summary>
public class ActionExamplesDemo
{
    public static void Run()
    {
        Console.WriteLine("\n═══════════════════════════════════════════════════════════");
        Console.WriteLine("ACTION DELEGATES (return void)");
        Console.WriteLine("═══════════════════════════════════════════════════════════\n");

        Example_Action_NoParams();
        Example_Action_OneParam();
        Example_Action_TwoParams();
        Example_Action_ThreeParams();
        Example_Action_NamedMethod();
        Example_Action_AnonymousMethod();
    }

    // Action with no parameters
    private static void Example_Action_NoParams()
    {
        Console.WriteLine("→ Action with no parameters:");
        Action greet = () => Console.WriteLine("   Hello!");
        greet();
        Console.WriteLine();
    }

    // Action with 1 parameter
    private static void Example_Action_OneParam()
    {
        Console.WriteLine("→ Action with 1 parameter:");
        Action<string> print = name => Console.WriteLine($"   Hello, {name}");
        print("Alice");
        Console.WriteLine();
    }

    // Action with 2 parameters
    private static void Example_Action_TwoParams()
    {
        Console.WriteLine("→ Action with 2 parameters:");
        Action<int, int> add = (a, b) => Console.WriteLine($"   Sum: {a + b}");
        add(5, 3);
        Console.WriteLine();
    }

    // Action with 3 parameters
    private static void Example_Action_ThreeParams()
    {
        Console.WriteLine("→ Action with 3 parameters:");
        Action<string, int, bool> log = (msg, num, flag) =>
            Console.WriteLine($"   Message: {msg}, Number: {num}, Flag: {flag}");
        log("Test", 42, true);
        Console.WriteLine();
    }

    // Action with named method instead of lambda
    private static void Example_Action_NamedMethod()
    {
        Console.WriteLine("→ Action with named method:");
        Action<string> greet = PrintGreeting;
        greet("Bob");
        Console.WriteLine();

        static void PrintGreeting(string name) => Console.WriteLine($"   Hello, {name}");
    }

    // Action with anonymous method
    private static void Example_Action_AnonymousMethod()
    {
        Console.WriteLine("→ Action with anonymous method:");
        Action<int> printNum = delegate (int x)
        {
            Console.WriteLine($"   Number: {x}");
        };
        printNum(10);
        Console.WriteLine();
    }
}

