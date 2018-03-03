using System;
using System.Collections.Generic;

public class Engine : IEngine
{
    private List<ICitizen> citizens;
    

    public Engine()
    {
        Citizens = new List<ICitizen>();
    }

    private List<ICitizen> Citizens
    {
        get => citizens;
        set => citizens = value;
    }

    

    public void Run()
    {
        while (true)
        {
            var input = Console.ReadLine().Trim();
            if ("End" == input)
            {
                break;
            }

            var tokens = input.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 2)
            {
                var model = tokens[0];
                var id = tokens[1];
                ICitizen robot = new Robot(model, id);
                Citizens.Add(robot);
            }
            else
            {
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var id = tokens[2];
                ICitizen citizen = new Citizen(name, age, id);
                Citizens.Add(citizen);
            }
        }
        var targetEnd = Console.ReadLine().Trim();
        foreach (var citizen in Citizens)
        {
            if (citizen.GetId().EndsWith(targetEnd))
            {
                Console.WriteLine(citizen.GetId());
            }
        }
    }
}