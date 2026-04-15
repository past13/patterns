using System;

namespace CommandPattern.Command2
{
    public class Receiver2
    {
        private string build = string.Empty;
        private string oldbuild = string.Empty;
        private string s = string.Empty;

        public void SetData(string input)
        {
            this.s = input;
        }

        public void DoIt()
        {
            oldbuild = build;
            build += s;
            Console.WriteLine("Receiver is building " + build);
        }
    }
}
