namespace Command.Command3
{
    public static class CommandLogger
    {
        private static int _count;

        public static void Log()
        {
            _count++;
        }

        public static int Count => _count;
    }
}
