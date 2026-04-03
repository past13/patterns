namespace Strategy;

internal interface IStrategy
{
    int Move(Context context);
}

internal sealed class Strategy1 : IStrategy
{
    public int Move(Context context) => ++context.Counter;
}

internal sealed class Strategy2 : IStrategy
{
    public int Move(Context context) => --context.Counter;
}

