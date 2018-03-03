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
            var command = tokens[0];
            switch (command)
            {
                case "Citizen":
                    var name = tokens[1];
                    var age = int.Parse(tokens[2]);
                    var id = tokens[3];
                    var birthday = tokens[4];
                    ICitizen citizen = new Person(name, age, id, birthday);
                    Citizens.Add(citizen);
                    break;
                case "Robot":
                    var model = tokens[1];
                    id = tokens[2];
                    ICitizen robot = new Robot(model, id);
                    Citizens.Add(robot);
                    break;
                case "Pet":
                    name = tokens[1];
                    birthday = tokens[2];
                    ICitizen pet = new Pet(name, birthday);
                    Citizens.Add(pet);
                    break;
            }
        }

        var targetEnd = Console.ReadLine().Trim();
        foreach (var citizen in Citizens)
        {
            if (citizen.GetBirthday().EndsWith(targetEnd))
            {
                Console.WriteLine(citizen.GetBirthday());
            }
        }
    }
}