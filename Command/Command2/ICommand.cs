namespace Command.Command2
{
    public interface ICommand
    {
        void Execute();
        void Redo();
        void Undo();
        void Set(string s);
    }
}
