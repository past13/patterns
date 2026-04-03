namespace Builder;

internal sealed class Director
{
    // Build a Product from several parts
    public void Construct(IBuilder builder)
    {
        builder.BuildPartA();
        builder.BuildPartB();
        builder.BuildPartB();
    }
}