namespace AbstractFactory;

/// <summary>
/// Client class that uses the abstract factory to create and use products.
/// </summary>
public class Client<TBrand>
    where TBrand : IBrand, new()
{
    public void Run()
    {
        var factory = new Factory<TBrand>();

        var bag = factory.CreateBag();
        var shoes = factory.CreateShoes();

        Console.WriteLine($"I bought a Bag which is made from {bag.Material}");
        Console.WriteLine($"I bought some shoes which cost {shoes.Price}");
    }
}

