using CommandPattern.Command2;

namespace Command.Command2
{
    public class CommandExample2 : ICommand
    {
        private readonly Receiver1 _receiver1;

        public CommandExample2(Receiver1 receiver1)
        {
            _receiver1 = receiver1;
        }

        public void Execute() => _receiver1.Action();
        public void Redo() => _receiver1.Action();
        public void Undo() => _receiver1.Reverse();
        public void Set(string s)
        {
            Console.WriteLine("Not implemented - default of XXX used");
            _receiver1.S = "XXX";
        }
    }
}
