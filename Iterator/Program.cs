namespace Iterator
{
    class Program
    {
        static void Main()
        {
            var collection = new MonthCollection();
            var selection = collection.GetFilteredMonths();

            foreach (var n in selection)
            {
                Console.Write(n.Key + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
