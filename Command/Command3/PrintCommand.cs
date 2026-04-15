namespace Command.Command3
{
    public class PrintCommand : ICommand
    {
        private readonly Document _document;

        public PrintCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            CommandLogger.Log();
            _document.Print();
        }

        public void Redo()
        {
            CommandLogger.Log();
            _document.Print();
        }

        public void Undo()
        {
            CommandLogger.Log();
            Console.WriteLine("Cannot undo a Print ");
        }
    }
}
