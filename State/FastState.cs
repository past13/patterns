namespace State;

internal sealed class FastState : IState
{
    public int MoveUp(Context context)
    {
        context.Counter += 5;
        return context.Counter;
    }

    public int MoveDown(Context context)
    {
        if (context.Counter < Context.Limit)
        {
            context.State = new NormalState();
            Console.Write("|| ");
        }

        context.Counter -= 5;
        return context.Counter;
    }
}

