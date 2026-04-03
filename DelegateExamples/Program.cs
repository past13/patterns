using DelegateExamples;

Console.Clear();
Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║              C# DELEGATES COMPREHENSIVE EXAMPLES                    ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");

bool running = true;
while (running)
{
    PrintMenu();
    Console.Write("\nEnter your choice (0-9): ");
    string? input = Console.ReadLine();

    running = HandleMenuChoice(input);
}

Console.WriteLine("\n✓ Thank you for exploring C# delegates!");

void PrintMenu()
{
    Console.WriteLine("\n┌──────────────────────────────────────────┐");
    Console.WriteLine("│         DELEGATE EXAMPLES MENU           │");
    Console.WriteLine("├──────────────────────────────────────────┤");
    Console.WriteLine("│ 1. ACTION DELEGATES (return void)        │");
    Console.WriteLine("│ 2. FUNC DELEGATES (return a value)       │");
    Console.WriteLine("│ 3. CUSTOM DELEGATES                      │");
    Console.WriteLine("│ 4. PREDICATE DELEGATES                   │");
    Console.WriteLine("│ 5. EVENT HANDLERS                        │");
    Console.WriteLine("│ 6. MULTICAST DELEGATES                   │");
    Console.WriteLine("│ 7. DELEGATE DEFINITION STYLES            │");
    Console.WriteLine("│ 8. PRACTICAL USE CASES                   │");
    Console.WriteLine("│ 9. RUN ALL EXAMPLES                      │");
    Console.WriteLine("│ 0. EXIT                                  │");
    Console.WriteLine("└──────────────────────────────────────────┘");
}

bool HandleMenuChoice(string? input)
{
    Console.Clear();

    switch (input)
    {
        case "1":
            ActionExamplesDemo.Run();
            break;
        case "2":
            FuncExamplesDemo.Run();
            break;
        case "3":
            CustomDelegateExamplesDemo.Run();
            break;
        case "4":
            PredicateExamplesDemo.Run();
            break;
        case "5":
            EventHandlerExamplesDemo.Run();
            break;
        case "6":
            MulticastDelegateExamplesDemo.Run();
            break;
        case "7":
            DelegateDefinitionStylesDemo.Run();
            break;
        case "8":
            PracticalExamplesDemo.Run();
            break;
        case "9":
            RunAllExamples();
            break;
        case "0":
            return false;
        default:
            Console.WriteLine("❌ Invalid choice. Please try again.");
            break;
    }

    if (input != "0")
    {
        Console.Write("\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }

    return true;
}

void RunAllExamples()
{
    ActionExamplesDemo.Run();
    FuncExamplesDemo.Run();
    CustomDelegateExamplesDemo.Run();
    PredicateExamplesDemo.Run();
    EventHandlerExamplesDemo.Run();
    MulticastDelegateExamplesDemo.Run();
    DelegateDefinitionStylesDemo.Run();
    PracticalExamplesDemo.Run();

    Console.WriteLine("\n═══════════════════════════════════════════════════════════");
    Console.WriteLine("✓ ALL EXAMPLES COMPLETED");
    Console.WriteLine("═══════════════════════════════════════════════════════════\n");
}
