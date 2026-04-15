namespace Command.Command3
{
    public interface ICommand
    {
        void Execute();
        void Redo();
        void Undo();
    }
}
