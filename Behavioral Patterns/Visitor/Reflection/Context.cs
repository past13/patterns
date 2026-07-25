namespace Reflection;

public class Context
{
    public string Input { get; set; }
    public double Output { get; set; }

    public Context(string input)
    {
        Input = input;
        Output = 0;
    }

    public int GetNumber()
    {
        int atSpace = Input.IndexOf(' ');
        int number = int.Parse(Input.Substring(1, atSpace));
        Input = Input.Substring(atSpace + 1);
        return number;
    }
}
