namespace AbstractFactory;

/// <summary>
/// Gucci brand - premium luxury brand.
/// </summary>
public class Gucci : IBrand
{
    public int Price => 1000;
    public string Material => "Crocodile skin";
}

/// <summary>
/// Poochy brand - budget-friendly brand (1/3 price of Gucci).
/// </summary>
public class Poochy : IBrand
{
    public int Price => new Gucci().Price / 3;
    public string Material => "Plastic";
}

/// <summary>
/// Groundcover brand - premium leather brand.
/// </summary>
public class Groundcover : IBrand
{
    public int Price => 2000;
    public string Material => "South african leather";
}

