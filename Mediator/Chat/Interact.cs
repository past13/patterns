using System;

namespace Mediator.Chat
{
    public class Interact
    {
        private string name;

        public Interact(string name)
        {
            this.name = name;
        }

        public event Callback? InputEvent;

        public void Input(string message)
        {
            InputEvent?.Invoke(message, name);
        }

        public void Output(string message)
        {
            Console.WriteLine($"[{name}'s screen] {message}");
        }
    }
}
