using System;
using System.Collections.Generic;

class CatLady
{
    static void Main()
    {
        var cats = new Dictionary<string, Cat>();
        while (true)
        {
            var input = Console.ReadLine();
            if ("End" == input)
            {
                break;
            }

            var tokens = input.Split();
            var cat = new Cat(tokens[0], tokens[1], tokens[2]);
            if (!cats.ContainsKey(tokens[1]))
            {
                cats[tokens[1]] = cat;
            }
        }

        Console.WriteLine(cats[Console.ReadLine()]);
    }
}