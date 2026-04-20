namespace Mediator.Chat
{
    public class Colleague
    {
        private Interact visuals;
        private string name;

        public Colleague(Mediator mediator, string name)
        {
            this.name = name;
            visuals = new Interact(name);
            mediator.SignOn(name, Receive, visuals);
        }

        public void Send(string message)
        {
            visuals.Input(message);
        }

        public void Receive(string message, string from)
        {
            visuals.Output(from + ": " + message);
        }
    }
}
