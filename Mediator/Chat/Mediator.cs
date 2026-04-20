using System;
using System.Threading;

namespace Mediator.Chat
{
    public class Mediator
    {
        private Callback? Respond;

        public void SignOn(string name, Callback receive, Interact visuals)
        {
            Respond += receive;
            visuals.InputEvent += Send;
        }

        public void Send(string message, string from)
        {
            if (message.IndexOf("work", StringComparison.OrdinalIgnoreCase) == -1)
            {
                Respond?.Invoke(message, from);
            }
        }
    }
}
