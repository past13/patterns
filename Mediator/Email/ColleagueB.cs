namespace Mediator.Email
{
    public class ColleagueB : Colleague
    {
        public ColleagueB(Mediator mediator, string name)
            : base(mediator, name)
        {
        }

        // Does not get copies of own messages
        public override void Receive(string message, string from)
        {
            if (!string.Equals(from, name))
            {
                Console.WriteLine(name + " received from " + from + ": " + message);
            }
        }
    }
}
