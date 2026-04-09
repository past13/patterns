using ChainOfResponsibility.SecondExample;

namespace ChainOfResponsibility;

internal static class Program
{
    private static void Main()
    {
        FirstExample.HandleFirstExample.Run();

        Console.WriteLine("\n\n=== Second Example: Bank Organization ===\n");
        BankApp.RunTheOrganization();
    }
}
