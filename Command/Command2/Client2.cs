using CommandPattern.Command2;

namespace Command.Command2;

public static class Client2
{
    public static void Run()
    {
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