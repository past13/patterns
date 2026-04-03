namespace PluggableAdapter;

// Existing way requests are implemented
class Adaptee
{
    public double Precise(double a, double b)
    {
        return a / b;
    }
}