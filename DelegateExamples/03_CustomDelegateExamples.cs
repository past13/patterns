namespace DelegateExamples;

/// <summary>
/// Custom delegates provide domain-specific names for better readability.
/// They're essentially the same as Action/Func, but self-documenting.
/// </summary>
public class CustomDelegateExamplesDemo
{
    // Custom delegate definitions
    public delegate void LogHandler(string message, LogLevel level);
    public delegate string FormatHandler(int value, string format);
    public delegate bool ValidatorHandler(string input);

    public enum LogLevel { Info, Warning, Error }

    public static void Run()
    {
        Console.WriteLine("\n═══════════════════════════════════════════════════════════");
        Console.WriteLine("CUSTOM DELEGATES");
        Console.WriteLine("═══════════════════════════════════════════════════════════\n");

        Example_CustomDelegate_Logging();
        Example_CustomDelegate_Formatting();
        Example_CustomDelegate_Validation();
    }

    // Example 1: Custom delegate for logging
    private static void Example_CustomDelegate_Logging()
    {
        Console.WriteLine("→ Custom delegate for logging:");
        LogHandler logger = (msg, level) =>
            Console.WriteLine($"   [{level}] {msg}");

        logger("Application started", LogLevel.Info);
        logger("Memory usage high", LogLevel.Warning);
        logger("Database connection failed", LogLevel.Error);
        Console.WriteLine();
    }

    // Example 2: Custom delegate for formatting
    private static void Example_CustomDelegate_Formatting()
    {
        Console.WriteLine("→ Custom delegate for formatting:");
        FormatHandler formatter = (value, format) =>
            format.ToLower() switch
            {
                "hex" => value.ToString("X"),
                "binary" => Convert.ToString(value, 2),
                "currency" => value.ToString("C"),
                _ => value.ToString()
            };

        Console.WriteLine($"   255 as hex: {formatter(255, "hex")}");
        Console.WriteLine($"   8 as binary: {formatter(8, "binary")}");
        Console.WriteLine($"   100 as currency: {formatter(100, "currency")}");
        Console.WriteLine();
    }

    // Example 3: Custom delegate for validation
    private static void Example_CustomDelegate_Validation()
    {
        Console.WriteLine("→ Custom delegate for validation:");
        ValidatorHandler emailValidator = input =>
            input.Contains("@") && input.Contains(".");

        Console.WriteLine($"   test@example.com is valid: {emailValidator("test@example.com")}");
        Console.WriteLine($"   invalid-email is valid: {emailValidator("invalid-email")}");
        Console.WriteLine();
    }
}

