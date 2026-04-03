namespace PluggableAdapter;

// New standard for requests
class Target
{
    public string Estimate(int i)
    {
        return "Estimate is " + (int)Math.Round(i / 3.0);
    }
}