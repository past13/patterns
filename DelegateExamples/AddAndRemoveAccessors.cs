namespace DelegateExamples;

public class SecureBroadcaster
{
    private Action _internalDelegate;

    public event Action SecureEvent
    {
        add
        {
            Console.WriteLine("Someone is subscribing!");
            _internalDelegate += value;
        }
        remove
        {
            Console.WriteLine("Someone is leaving.");
            _internalDelegate -= value;
        }
    }
}