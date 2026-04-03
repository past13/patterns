namespace Builder;

internal interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    Product GetResult();
}

internal sealed class Builder1 : IBuilder
{
    private readonly Product _product = new();

    public void BuildPartA() => _product.Add("PartA");
    public void BuildPartB() => _product.Add("PartB");
    public Product GetResult() => _product;
}

internal sealed class Builder2 : IBuilder
{
    private readonly Product _product = new();

    public void BuildPartA() => _product.Add("PartX");
    public void BuildPartB() => _product.Add("PartY");
    public Product GetResult() => _product;
}
