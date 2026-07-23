namespace Observer
{
    static class Program
    {
        private static void Main()
        {
            Subject subject = new Subject();
            Observer observer1 = new Observer(subject, "Center", "\t\t");
            Observer observer2 = new Observer(subject, "Right", "\t\t\t\t");
            subject.Go();
            
            // Wait to allow threads to finish output
            System.Threading.Thread.Sleep(1500);
        }
    }
}
