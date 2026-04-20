namespace Mediator
{
    public class Mediator
    {
        public delegate void Callback(string message, string from);
        private Callback? respond;

        public void SignOn(Callback method)
        {
            respond += method;
        }

        public void Block(Callback method)
        {
            respond -= method;
        }

        public void Unblock(Callback method)
        {
            respond += method;
        }

        // Send is implemented as a broadcast
        public void Send(string message, string from)
        {
            respond?.Invoke(message, from);
            Console.WriteLine();
        }
    }
}
