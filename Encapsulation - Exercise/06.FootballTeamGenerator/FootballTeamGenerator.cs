class FootballTeamGenerator
{
    static void Main()
    {
        InputReader reader = new InputReader();
        OutputWriter writer = new OutputWriter();
        IEngine engine = new Engine(reader, writer);

        engine.Run();
    }
}