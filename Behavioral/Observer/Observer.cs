namespace Observer
{
    public class Observer : IObserver
    {
        private readonly string _name;
        private Subject _subject;
        string state;
        private readonly string _gap;

        public Observer(Subject subject, string name, string gap)
        {
            _subject = subject;
            _name = name;
            _gap = gap;
            subject.Notify += Update;
        }

        public void Update(string subjectState)
        {
            state = subjectState;
            Console.WriteLine(_gap + _name + ": " + state);
        }
    }
}
