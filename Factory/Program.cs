namespace Factory;

// Factory Method Pattern

interface IProduct
{
    string ShipFrom();
}

class ProductA : IProduct
{
    public string ShipFrom() => "from South Africa";
}

class ProductB : IProduct
{
    public string ShipFrom() => "from Spain";
}

class DefaultProduct : IProduct
{
    public string ShipFrom() => "not available";
}

class Creator
{
    public IProduct FactoryMethod(int month)
    {
        if (month >= 4 && month <= 11)
        {
            return new ProductA();
        }
        
        if (month == 1 || month == 2 || month == 12)
        {
            return new ProductB();
        }
        
        return new DefaultProduct();
    }
}

class Program
{
    static void Main()
    {
        Creator creator = new Creator();
        for (int i = 1; i <= 12; i++)
        {
            IProduct product = creator.FactoryMethod(i);
            Console.WriteLine($"Avocados {product.ShipFrom()}");
        }
    }
}
