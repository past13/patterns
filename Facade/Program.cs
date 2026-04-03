namespace Facade;

internal sealed class SubsystemA
{
    public string MethodA1() => "Subsystem A, Method A1";
    public string MethodA2() => "Subsystem A, Method A2";
}

internal sealed class SubsystemB
{
    public string MethodB1() => "Subsystem B, Method B1";
}

internal sealed class SubsystemC
{
    public string MethodC1() => "Subsystem C, Method C1";
}

public static class Facade
{
    private static readonly SubsystemA A = new();
    private static readonly SubsystemB B = new();
    private static readonly SubsystemC C = new();

    public static void Operation1()
    {
        Console.WriteLine("Operation 1");
        Console.WriteLine(A.MethodA1());
        Console.WriteLine(A.MethodA2());
        Console.WriteLine(B.MethodB1());
        Console.WriteLine();
    }

    public static void Operation2()
    {
        Console.WriteLine("Operation 2");
        Console.WriteLine(B.MethodB1());
        Console.WriteLine(C.MethodC1());
    }
}

internal static class Program
{
    private static void Main()
    {
        Facade.Operation1();
        Facade.Operation2();
    }
}