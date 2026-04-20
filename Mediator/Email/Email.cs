namespace Mediator.Email;

public class Email
{
        public static void Run()
        {
            Mediator m = new Mediator();
            // Two from head office and one from a branch office
            Colleague head1 = new Colleague(m, "John");
            ColleagueB branch1 = new ColleagueB(m, "David");
            Colleague head2 = new Colleague(m, "Lucy");

            head1.Send("Meeting on Tuesday, please all ack");
            branch1.Send("Ack"); // by design does not get a copy
            m.Block(branch1.Receive); // temporarily gets no messages
            head1.Send("Still awaiting some Acks");
            head2.Send("Ack");
            m.Unblock(branch1.Receive); // open again
            head1.Send("Thanks all");
        }
}