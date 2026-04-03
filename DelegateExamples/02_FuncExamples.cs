namespace DelegateExamples;

/// <summary>
/// Func delegates represent methods that return a value.
/// Last type parameter is always the return type.
/// They can have 0 to 16 input parameters.
/// </summary>
public class FuncExamplesDemo
{
    public static void Run()
    {
        Console.WriteLine("\n═══════════════════════════════════════════════════════════");
        Console.WriteLine("FUNC DELEGATES (return a value)");
        Console.WriteLine("═══════════════════════════════════════════════════════════\n");

        Example_Func_NoParams();
        Example_Func_OneParam();
        Example_Func_TwoParams();
        Example_Func_ThreeParams();
        Example_Func_NamedMethod();
        Example_Func_AnonymousMethod();
        Example_Func_Pipeline();
    }

    // Func with no parameters, returns string
    private static void Example_Func_NoParams()
    {
        Console.WriteLine("→ Func with no parameters, returns string:");
        Func<string> getName = () => "Alice";
        string name = getName();
        Console.WriteLine($"   Result: {name}");
        Console.WriteLine();
    }

    // Func with 1 parameter, returns int
    private static void Example_Func_OneParam()
    {
        Console.WriteLine("→ Func with 1 parameter, returns int:");
        Func<int, int> square = x => x * x;
        int result = square(5);
        Console.WriteLine($"   Square of 5 = {result}");
        Console.WriteLine();
    }

    // Func with 2 parameters, returns string
    private static void Example_Func_TwoParams()
    {
        Console.WriteLine("→ Func with 2 parameters, returns string:");
        Func<string, int, string> repeat = (text, count) => 
            string.Concat(Enumerable.Repeat(text, count));
        string result = repeat("Ha", 3);
        Console.WriteLine($"   Result: {result}");
        Console.WriteLine();
    }

    // Func with 3 parameters, returns double
    private static void Example_Func_ThreeParams()
    {
        Console.WriteLine("→ Func with 3 parameters, returns double:");
        Func<double, double, double, double> calculate = (a, b, c) =>
            (a + b) * c;
        double result = calculate(2, 3, 4);
        Console.WriteLine($"   Calculate (2+3)*4 = {result}");
        Console.WriteLine();
    }

    // Func with named method
    private static void Example_Func_NamedMethod()
    {
        Console.WriteLine("→ Func with named method:");
        Func<int, int, int> multiply = Multiply;
        int result = multiply(6, 7);
        Console.WriteLine($"   6 × 7 = {result}");
        Console.WriteLine();

        static int Multiply(int a, int b) => a * b;
    }

    // Func with anonymous method
    private static void Example_Func_AnonymousMethod()
    {
        Console.WriteLine("→ Func with anonymous method:");
        Func<int, string> toHek = delegate (int num)
        {
            return num.ToString("X");
        };
        string result = toHek(255);
        Console.WriteLine($"   255 in hex = {result}");
        Console.WriteLine();
    }

    // Func in real-world: data transformation pipeline
    private static void Example_Func_Pipeline()
    {
        Console.WriteLine("→ Func pipeline (chaining operations):");
        Func<int, int> addOne = x => x + 1;
        Func<int, int> double_ = x => x * 2;
        Func<int, string> toText = x => $"Result: {x}";

        int input = 5;
        int step1 = addOne(input);      // 6
        int step2 = double_(step1);     // 12
        string output = toText(step2);  // "Result: 12"
        
        Console.WriteLine($"   Input: {input}");
        Console.WriteLine($"   After +1: {step1}");
        Console.WriteLine($"   After ×2: {step2}");
        Console.WriteLine($"   {output}");
        Console.WriteLine();
    }
}

