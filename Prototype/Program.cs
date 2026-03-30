namespace CreationalPatterns;

[Serializable]
public abstract class IPrototype<T> where T : class
{
    // Shallow copy: nested reference members remain shared.
    public T Clone()
    {
        return (T)MemberwiseClone();
    }

    // Deep copy via JSON round-trip (safe replacement for BinaryFormatter).
    public T DeepCopy()
    {
        string json = System.Text.Json.JsonSerializer.Serialize((T)(object)this);
        T? copy = System.Text.Json.JsonSerializer.Deserialize<T>(json);
        return copy ?? throw new InvalidOperationException("Deep copy failed.");
    }
}

internal static class Program
{
    private static void Main()
    {
        PrototypeClient.Run();
    }
}
