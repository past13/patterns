namespace State;

internal sealed class Context
{
    public const int Limit = 10;

    public IState State { get; set; }

    public int Counter { get; set; } = Limit;

    public Context(IState state)
    {
        State = state;
    }

    public int Request(int command)
    {
        return command == 2 ? State.MoveUp(this) : State.MoveDown(this);
    }
}

