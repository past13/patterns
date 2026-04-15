namespace Command.Command1;

public static class Client1
{
        public static void Run()
        {
            var receiver = new Receiver();
            var command1 = new Command(receiver);

            command1.Execute();
            command1.Redo();
            command1.Undo();
            command1.Execute();
        }
}