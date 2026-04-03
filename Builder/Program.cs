namespace Builder;

internal static class Program
{
    private static void Main()
    {
        var director = new Director();

        IBuilder b1 = new Builder1();
        IBuilder b2 = new Builder2();

        // Construct two products
        director.Construct(b1);
        b1.GetResult().Display();

        director.Construct(b2);
        b2.GetResult().Display();
    }
}
