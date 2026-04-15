namespace Command.Command3
{
    public class PasteCommand : ICommand
    {
        private readonly Document _document;

        public PasteCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            CommandLogger.Log();
            _document.Paste(AppState.Clipboard);
        }

        public void Redo()
        {
            CommandLogger.Log();
            _document.Paste(AppState.Clipboard);
        }

        public void Undo()
        {
            CommandLogger.Log();
            _document.Restore();
        }
    }
}
