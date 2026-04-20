namespace Iterator
{
    public class MonthCollection
    {
        public Dictionary<string, int> DaysInMonths { get; } = new Dictionary<string, int>
        {
            {"January", 31}, {"February", 28},
            {"March", 31}, {"April", 30},
            {"May", 31}, {"June", 30},
            {"July", 31}, {"August", 31},
            {"September", 30}, {"October", 31},
            {"November", 30}, {"December", 31}
        };

        public IEnumerable<KeyValuePair<string, int>> GetFilteredMonths()
        {
            var selection = from n in DaysInMonths
                            where n.Key.Length > 5
                            select n;

            selection = from n in selection
                        where n.Value == 31
                        orderby n.Key
                        select n;

            return selection;
        }
    }
}
