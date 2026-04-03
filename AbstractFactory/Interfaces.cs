namespace AbstractFactory;

/// <summary>
/// Generic abstract factory interface for creating product families.
/// </summary>
public interface IFactory
{
    IBag CreateBag();
    IShoes CreateShoes();
}

/// <summary>
/// Interface for Bag products.
/// </summary>
public interface IBag
{
    string Material { get; }
}

/// <summary>
/// Interface for Shoes products.
/// </summary>
public interface IShoes
{
    int Price { get; }
}

/// <summary>
/// Interface for Brand specifications.
/// </summary>
public interface IBrand
{
    int Price { get; }
    string Material { get; }
}

