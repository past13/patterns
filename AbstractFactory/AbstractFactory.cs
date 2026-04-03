namespace AbstractFactory;

/// <summary>
/// Generic concrete factory implementation.
/// Creates products based on the specified brand type.
/// </summary>
public class Factory<TBrand> : IFactory
    where TBrand : IBrand, new()
{
    public IBag CreateBag()
    {
        return new Bag<TBrand>();
    }

    public IShoes CreateShoes()
    {
        return new Shoes<TBrand>();
    }
}

/// <summary>
/// Generic Bag implementation that uses a brand to provide material information.
/// </summary>
public class Bag<TBrand> : IBag
    where TBrand : IBrand, new()
{
    private readonly TBrand _brand;

    public Bag()
    {
        _brand = new TBrand();
    }

    public string Material => _brand.Material;
}

/// <summary>
/// Generic Shoes implementation that uses a brand to provide price information.
/// </summary>
public class Shoes<TBrand> : IShoes
    where TBrand : IBrand, new()
{
    private readonly TBrand _brand;

    public Shoes()
    {
        _brand = new TBrand();
    }

    public int Price => _brand.Price;
}

