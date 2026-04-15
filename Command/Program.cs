using Command.Command1;
using Command.Command2;
using Command.Command3;

namespace Command
{
    internal static class Program
    {
        private static void Main()
        { 
            Client1.Run();
            
            Client2.Run();
            
            Client3.Run();
        }
    }
}
