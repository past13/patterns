namespace Command.Command1
{
    public class Command
    {
        public Action Execute { get; }
        public Action Undo { get; }
        public Action Redo { get; }

        public Command(Receiver receiver)
        {
            Execute = receiver.Action;
            Redo = receiver.Action;
            Undo = receiver.Reverse;
        }
    }
}
