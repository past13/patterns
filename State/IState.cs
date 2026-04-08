namespace State;

internal interface IState
{
    int MoveUp(Context context);
    int MoveDown(Context context);
}

