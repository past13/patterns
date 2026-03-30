namespace Singletone;
// Singleton Pattern — lazy instantiation via nested class (thread-safe)

public class ThreadSafeSingleton
{
    // Private constructor — prevents direct instantiation
    private ThreadSafeSingleton() { }

    // Nested class handles lazy, thread-safe creation
    private class SingletonCreator
    {
        static SingletonCreator() { }
        internal static readonly ThreadSafeSingleton Instance = new ThreadSafeSingleton();
    }

    // Public access point
    public static ThreadSafeSingleton UniqueInstance => SingletonCreator.Instance;
}
