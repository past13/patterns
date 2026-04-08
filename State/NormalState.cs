namespace State;

internal sealed class NormalState : IState
{
    public int MoveUp(Context context)
    {
        context.Counter += 2;
        return context.Counter;
    }

    public int MoveDown(Context context)
    {
        if (context.Counter < Context.Limit)
        {
            context.State = new FastState();
            Console.Write("|| ");
        }

        context.Counter -= 2;
        return context.Counter;
    }
}

