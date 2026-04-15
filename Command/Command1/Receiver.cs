namespace Command.Command1
{
    public class Receiver
    {
        private string build = string.Empty;
        private string oldbuild = string.Empty;
        private const string s = "some string ";

        public void Action()
        {
            oldbuild = build;
            build += s;
            Console.WriteLine("Receiver is adding " + build);
        }

        public void Reverse()
        {
            build = oldbuild;
            Console.WriteLine("Receiver is reverting to " + build);
        }
    }
}
