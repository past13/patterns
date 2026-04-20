using System;

namespace Mediator.Chat
{
    public class Chat
    {
        public static void Run()
        {
            Console.WriteLine("--- Chat Interaction Started ---");
            Mediator m = new Mediator();
            Colleague chat1 = new Colleague(m, "John");
            Colleague chat2 = new Colleague(m, "David");
            Colleague chat3 = new Colleague(m, "Lucy");

            chat1.Send("Hi everyone!");
            chat2.Send("How are you, John?");
            chat3.Send("What about the work we have to do?"); // Gets filtered out
            chat1.Send("Let's go grab a coffee.");
            Console.WriteLine("--- Chat Interaction Ended ---\n");
        }
    }
}
