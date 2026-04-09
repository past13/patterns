namespace ChainOfResponsibility.SecondExample;

internal sealed class BankApp
{
    private static void AdjustChain()
    {
        // Placeholder for chain adjustments
    }

    public static void RunTheOrganization()
    {
        Console.WriteLine("Trusty Bank opens with:");

        foreach (Level level in Enum.GetValues(typeof(Level)))
        {
            var positions = BankContext.Structure[level].Positions;
            var limit = BankContext.Structure[level].Limit;

            for (var i = 0; i < positions; i++)
            {
                BankContext.HandlersAtLevel[level].Add(new BankHandler(i, level));
            }

            Console.WriteLine($"{positions} {level}(s) who deal up to a limit of {limit}");
        }

        Console.WriteLine();

        int[] amounts = [50, 2000, 1500, 10000, 175, 4500, 2000];

        foreach (var amount in amounts)
        {
            try
            {
                var clerkPositions = BankContext.Structure[Level.Clerk].Positions;
                var whichClerk = BankContext.Choice.Next(clerkPositions);
                
                Console.Write($"Approached Clerk {whichClerk}. ");
                Console.WriteLine(BankContext.HandlersAtLevel[Level.Clerk][whichClerk].HandleRequest(amount));
                
                AdjustChain();
            }
            catch (ChainException e)
            {
                Console.WriteLine($"\nNo facility to handle a request of {e.Data["Limit"]}");
                Console.WriteLine("Try breaking it down into smaller requests\n");
            }
        }
    }
}