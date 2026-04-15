using CommandPattern.Command2;

namespace Command.Command2
{
    public class CommandExample1 : ICommand
    {
        private readonly Receiver2 _receiver;

        public CommandExample1(Receiver2 receiver)
        {
            _receiver = receiver;
        }

        public void Execute() => _receiver.DoIt();
        public void Redo() => _receiver.DoIt();
        public void Undo() => Console.WriteLine("Not Implemented");
        public void Set(string s) => _receiver.SetData(s);
    }
}
