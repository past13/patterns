namespace ChainOfResponsibility.SecondExample;

internal static class BankContext
{
    public static readonly Random Choice = new(11);
    public static readonly Level FirstLevel = Level.Manager;

    public static readonly Dictionary<Level, RoleStructure> Structure = new()
    {
        { Level.Manager, new RoleStructure { Limit = 9000, Positions = 1 } },
        { Level.Supervisor, new RoleStructure { Limit = 4000, Positions = 3 } },
        { Level.Clerk, new RoleStructure { Limit = 1000, Positions = 10 } }
    };

    public static readonly Dictionary<Level, List<BankHandler>> HandlersAtLevel = new()
    {
        { Level.Manager, new List<BankHandler>() },
        { Level.Supervisor, new List<BankHandler>() },
        { Level.Clerk, new List<BankHandler>() }
    };
}

