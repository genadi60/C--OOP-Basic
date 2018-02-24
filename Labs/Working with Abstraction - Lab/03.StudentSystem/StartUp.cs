namespace P03_StudentSystem
{
    class StartUp
    {
        static void Main()
        {
            var manager = new CommandManager();
            while (true)
            {
                if (manager.ParseCommand())
                {
                    break;
                }
            }
        }
    }
}