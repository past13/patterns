
namespace Command.Command3
{
    public class Document
    {
        private string name;
        private string oldpage, page;

        public Document(string name)
        {
            this.name = name;
        }

        public void Paste(string clipboardText)
        {
            oldpage = page;
            page += clipboardText + "\n";
        }

        public void Restore()
        {
            page = oldpage;
        }

        public void Print()
        {
            Console.WriteLine("File " + name + " at " + DateTime.Now + "\n" + page);
        }
    }
}
