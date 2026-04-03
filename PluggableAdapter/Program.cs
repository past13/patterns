// Adapter Pattern - Pluggable
// The Adapter can accept any number of pluggable adaptees and targets
// and route the requests via a delegate, in some cases using the
// anonymous delegate construct.

namespace PluggableAdapter;

// Implementing new requests via old
class Adapter : IAdapter
{
    private readonly Func<int, string> _request;

    // Different constructors for the expected targets/adaptees
    // Adapter-Adaptee
    public Adapter(Adaptee adaptee)
    {
        // Set the delegate to the new standard
        _request = delegate (int i)
        {
            return "Estimate based on precision is " + (int)Math.Round(adaptee.Precise(i, 3));
        };
    }

    // Adapter-Target
    public Adapter(Target target)
    {
        // Set the delegate to the existing standard
        _request = target.Estimate;
    }

    public string Request(int i) => _request(i);
}

class Client
{
    static void Main()
    {
        IAdapter adapter1 = new Adapter(new Adaptee());
        Console.WriteLine(adapter1.Request(5));

        IAdapter adapter2 = new Adapter(new Target());
        Console.WriteLine(adapter2.Request(5));
    }
}