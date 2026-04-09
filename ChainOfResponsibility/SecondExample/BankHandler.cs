namespace ChainOfResponsibility.SecondExample;

internal sealed class BankHandler(int id, Level level)
{
    public string HandleRequest(int data)
    {
        if (data < BankContext.Structure[level].Limit)
        {
            return $"Request for {data} handled by {level} {id}";
        }

        if (level > BankContext.FirstLevel)
        {
            var nextLevel = level - 1;
            var which = BankContext.Choice.Next(BankContext.Structure[nextLevel].Positions);
            return BankContext.HandlersAtLevel[nextLevel][which].HandleRequest(data);
        }

        var exception = new ChainException();
        exception.Data.Add("Limit", data);
        throw exception;
    }
}

