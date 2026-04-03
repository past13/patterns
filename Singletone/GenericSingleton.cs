namespace Singletone;
// Generic Singleton Pattern — lazy, thread-safe instantiation via nested class

public class GenericSingleton<T> where T : class, new()
{
    private GenericSingleton() { }

    private class SingletonCreator
    {
        static SingletonCreator() { }
        internal static readonly T Instance = new T();
    }

    public static T UniqueInstance => SingletonCreator.Instance;
}

class Test1 { }
class Test2 { }
