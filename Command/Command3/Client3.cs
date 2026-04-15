using System;

namespace Command.Command3
{
    public static class Client3
    {
        public static void Run()
        {
            Document document = new Document("Greetings");
            ICommand paste = new PasteCommand(document);
            ICommand print = new PrintCommand(document);

            AppState.Clipboard = "Hello, everyone";
            paste.Execute();
            print.Execute();
            paste.Undo();
            
            AppState.Clipboard = "Bonjour, mes amis";
            paste.Execute();
            
            AppState.Clipboard = "Guten morgen, meine Freunde";
            paste.Redo();
            print.Execute();
            print.Undo();

            Console.WriteLine("Logged " + CommandLogger.Count + " commands");
        }
    }
}