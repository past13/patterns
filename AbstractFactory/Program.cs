namespace AbstractFactory;

using System;

/// <summary>
/// Example program demonstrating the Abstract Factory Pattern with generics.
/// 
/// The Abstract Factory pattern provides an interface for creating families of 
/// related or dependent objects without specifying their concrete classes.
/// 
/// This implementation uses C# generics to simplify factory creation.
/// Different brands can be used to create matching sets of products.
/// </summary>
static class Program
{
    static void Main()
    {
        Console.WriteLine("=== Abstract Factory Pattern Example ===\n");

        Console.WriteLine("--- Poochy Products ---");
        new Client<Poochy>().Run();

        Console.WriteLine("\n--- Gucci Products ---");
        new Client<Gucci>().Run();

        Console.WriteLine("\n--- Groundcover Products ---");
        new Client<Groundcover>().Run();
    }
}
