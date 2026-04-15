using Command.Command2;
using CommandPattern.Command2;
using Receiver = Command.Command1.Receiver;

namespace Command
{
    internal static class Program
    {
        private static void Main()
        {
            var receiver = new Receiver();
            var command1 = new Command1.Command(receiver);

            command1.Execute();
            command1.Redo();
            command1.Undo();
            command1.Execute();
            
            ICommand command = new CommandExample2(new Receiver1());
            command.Execute();
            command.Redo();
            command.Undo();
            command.Set("III");
            command.Execute();

            Console.WriteLine();
            
            ICommand command2 = new CommandExample1(new Receiver2());
            command2.Set("houses ");
            command2.Execute();
            
            command2.Set("castles ");
            command2.Undo();
            command2.Execute();
            command2.Redo();
        }
    }
}
