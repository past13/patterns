namespace DelegateExamples;

public interface IEngine
{
    // Allowed: Classes must implement this event
    event Action OnOverheat;

    // NOT Allowed: Interfaces cannot contain fields
    // Action OnWarning; 
}

public class CarEngine : IEngine
{
    public event Action OnOverheat; // Implementation
}