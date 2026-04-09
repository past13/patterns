namespace ChainOfResponsibility;

internal sealed class Handler(int id, Handler? next)
{
    private int Limit { get; } = id * 1000;

    public string HandleRequest(int data) =>
        data < Limit
            ? $"Request for {data} handled at level {id}"
            : next?.HandleRequest(data) ?? $"Request for {data} handled BY DEFAULT at level {id}";
}
