using System;
using System.Collections.Generic;
using System.Linq;

public class Engine : IEngine
{
    private Dictionary<string, IBuyer> buyers;
    

    public Engine()
    {
        Buyers = new Dictionary<string, IBuyer>();
    }

    private Dictionary<string, IBuyer> Buyers
    {
        get => buyers;
        set => buyers = value;
    }
    
    public void Run()
    {
        var citizensCounter = int.Parse(Console.ReadLine());
        for (int index = 0; index < citizensCounter; index++)
        {
            var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 3)
            {
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var group = tokens[2];
                IBuyer rebel = new Rebel(name, age, group);
                if (!Buyers.ContainsKey(name))
                {
                    Buyers[name] = rebel;
                }
                
            }
            else
            {
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var id = tokens[2];
                var birthday = tokens[3];
                IBuyer person = new Person(name, age, id, birthday);
                if (!Buyers.ContainsKey(name))
                {
                    Buyers[name] = person;
                }
            }
        }
        
        while (true)
        {
            var name = Console.ReadLine().Trim();
            if ("End" == name)
            {
                break;
            }

            if (Buyers.ContainsKey(name))
            {
                Buyers[name].BuyFood();
            }
        }

        var result = Buyers.Values.Select(y => y.Food).Sum();
        Console.WriteLine(result);
    }
}