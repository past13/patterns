namespace Strategy;

internal sealed class Context
{
    public const int Start = 5;

    public int Counter { get; set; } = Start;

    private IStrategy _strategy = new Strategy1();

    public int Algorithm() => _strategy.Move(this);

    public void SwitchStrategy()
    {
        _strategy = _strategy is Strategy1 ? new Strategy2() : new Strategy1();
    }
}

