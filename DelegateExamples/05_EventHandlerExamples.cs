namespace DelegateExamples;

/// <summary>
/// EventHandler delegates follow a pattern: (object sender, EventArgs e)
/// Used for event-driven programming.
/// </summary>
public class EventHandlerExamplesDemo
{
    // Custom EventArgs
    public class ButtonClickedEventArgs : EventArgs
    {
        public DateTime ClickTime { get; set; }
        public int ClickCount { get; set; }
    }

    // Button class with events
    public class SimpleButton
    {
        private int clickCount = 0;

        // Event with custom EventArgs
        public event EventHandler<ButtonClickedEventArgs>? OnClick;

        public void Click()
        {
            clickCount++;
            OnClick?.Invoke(this, new ButtonClickedEventArgs
            {
                ClickTime = DateTime.Now,
                ClickCount = clickCount
            });
        }
    }

    public static void Run()
    {
        Console.WriteLine("\n═══════════════════════════════════════════════════════════");
        Console.WriteLine("EVENT HANDLERS");
        Console.WriteLine("═══════════════════════════════════════════════════════════\n");

        Example_EventHandler();
    }

    // Example: subscribing to events
    private static void Example_EventHandler()
    {
        Console.WriteLine("→ Event handler with custom EventArgs:");
        SimpleButton button = new();

        // Subscribe with lambda
        button.OnClick += (sender, e) =>
            Console.WriteLine($"   [Lambda] Button clicked at {e.ClickTime:HH:mm:ss}, Count: {e.ClickCount}");

        // Subscribe with named method
        button.OnClick += OnButtonClicked;

        button.Click();
        button.Click();
        button.Click();
        Console.WriteLine();

        static void OnButtonClicked(object? sender, ButtonClickedEventArgs e)
        {
            Console.WriteLine($"   [Named method] Click #{e.ClickCount}");
        }
    }
}

