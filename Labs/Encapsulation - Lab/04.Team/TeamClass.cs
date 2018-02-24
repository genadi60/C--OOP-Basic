using System;

class TeamClass
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var team = new Team("Dunav");
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            try
            {
                var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    decimal.Parse(cmdArgs[3]));

                team.AddPlayer(person);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                continue;
            }
        }

        Console.WriteLine(team);
    }
}