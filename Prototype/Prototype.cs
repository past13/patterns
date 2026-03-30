
namespace CreationalPatterns;

[Serializable]
internal class DeeperData
{
    public string Data { get; set; }

    public DeeperData()
    {
        Data = string.Empty;
    }

    public DeeperData(string data)
    {
        Data = data;
    }

    public override string ToString()
    {
        return Data;
    }
}

[Serializable]
internal class Prototype : IPrototype<Prototype>
{
    public string Country { get; set; }
    public string Capital { get; set; }
    public DeeperData Language { get; set; }

    public Prototype()
    {
        Country = string.Empty;
        Capital = string.Empty;
        Language = new DeeperData();
    }

    public Prototype(string country, string capital, string language)
    {
        Country = country;
        Capital = capital;
        Language = new DeeperData(language);
    }

    public override string ToString()
    {
        return $"{Country}\t\t{Capital}\t\t->{Language}";
    }
}

[Serializable]
internal class PrototypeManager
{
    public Dictionary<string, Prototype> Prototypes { get; } = new()
    {
        { "Germany", new Prototype("Germany", "Berlin", "German") },
        { "Italy", new Prototype("Italy", "Rome", "Italian") },
        { "Australia", new Prototype("Australia", "Canberra", "English") }
    };
}

internal static class PrototypeClient
{
    private static void Report(string message, Prototype prototype, Prototype clone)
    {
        Console.WriteLine($"\n{message}");
        Console.WriteLine($"Prototype {prototype}\nClone {clone}");
    }

    public static void Run()
    {
        PrototypeManager manager = new PrototypeManager();

        Prototype c2 = manager.Prototypes["Australia"].Clone();
        Report("Shallow cloning Australia\n===============", manager.Prototypes["Australia"], c2);

        c2.Capital = "Sydney";
        Report("Altered clone shallow state, prototype unaffected", manager.Prototypes["Australia"], c2);

        c2.Language.Data = "Chinese";
        Report("Altering clone deep state: prototype affected *****", manager.Prototypes["Australia"], c2);

        Prototype c3 = manager.Prototypes["Germany"].DeepCopy();
        Report("Deep cloning Germany\n============", manager.Prototypes["Germany"], c3);

        c3.Capital = "Munich";
        Report("Altering clone shallow state, prototype unaffected", manager.Prototypes["Germany"], c3);

        c3.Language.Data = "Turkish";
        Report("Altering clone deep state, prototype unaffected", manager.Prototypes["Germany"], c3);
    }
}
