namespace Singletone;





class Program
{
    static void Main()
    {
        var t1 = ThreadSafeSingleton.UniqueInstance;
        var t2 = ThreadSafeSingleton.UniqueInstance;
        Console.WriteLine($"t1 == t2 (same instance): {ReferenceEquals(t1, t2)}");

        Test1 t1a = GenericSingleton<Test1>.UniqueInstance;
        Test1 t1b = GenericSingleton<Test1>.UniqueInstance;
        Test2 t2a  = GenericSingleton<Test2>.UniqueInstance;

        Console.WriteLine($"t1a == t1b (same instance): {ReferenceEquals(t1a, t1b)}");
        Console.WriteLine($"t2  == t2  (same instance): {ReferenceEquals(t2a, GenericSingleton<Test2>.UniqueInstance)}");
    }
}
