namespace Command.Command2
{
    public class Receiver1
    {
        private string build = string.Empty;
        private string oldbuild = string.Empty;
        private string s = "some string ";

        public string S
        {
            get => s;
            set => s = value;
        }

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
