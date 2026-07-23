namespace Observer
{
    public class Subject
    {
        public delegate void Callback(string s);
        public event Callback Notify;

        private readonly Simulator _simulator = new Simulator();
        private const int Speed = 200;
        public string SubjectState { get; set; }

        public void Go()
        {
            new Thread(new ThreadStart(Run)).Start();
        }

        void Run()
        {
            foreach (string s in _simulator)
            {
                Console.WriteLine("Subject: " + s);
                SubjectState = s;
                Notify?.Invoke(s);
                Thread.Sleep(Speed); // milliseconds
            }
        }
    }
}
