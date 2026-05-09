namespace DelegateExamples;

public class Terminal
{
    // A simple delegate: Anyone can trigger this!
    public Action<string> OnInputDelegate;

    // An event: Only this class can trigger this.
    public event Action<string> OnInputEvent;

    public void SimulateInput(string text)
    {
        // Internal invocation is allowed for both
        OnInputDelegate?.Invoke(text);
        OnInputEvent?.Invoke(text);
    }
}

public class Hacker
{
    public void Test()
    {
        var term = new Terminal();

        // 1. I can trigger the delegate from outside! (Dangerous)
        term.OnInputDelegate?.Invoke("System Hacked");

        // 2. This will NOT compile. 
        // term.OnInputEvent?.Invoke("System Hacked"); 
        // Error: The event can only appear on the left hand side of += or -=
    }
}
