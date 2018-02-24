using System;
using System.Collections.Generic;
using System.Linq;

class PokemonTrainer
{
    private static Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
    static void Main()
    {
        
        while (true)
        {
            var input = Console.ReadLine();
            if ("Tournament" == input)
            {
                break;
            }

            var tokens = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            var trainersName = tokens[0];
            var pokemonName = tokens[1];
            var element = tokens[2];
            var health = int.Parse(tokens[3]);
            var pokemon = new Pokemon(pokemonName, element, health);
            if (!trainers.ContainsKey(trainersName))
            {
                trainers[trainersName] = new Trainer(trainersName);
            }
            trainers[trainersName].Collection.Add(pokemon);
        }

        while (true)
        {
            var input = Console.ReadLine();
            if ("End" == input)
            {
                break;
            }

            switch (input)
            {
                case "Fire":
                    CheckTranersPokemons(input);
                    break;
                case "Water":
                    CheckTranersPokemons(input);
                    break;
                case "Electricity":
                    CheckTranersPokemons(input);
                    break;
            }
        }

        foreach (Trainer trainer in trainers.Values.OrderByDescending(y => y.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Collection.Count}");
        }
    }

    private static void CheckTranersPokemons(string element)
    {
        foreach (Trainer trainer in trainers.Values)
        {
            bool contains = false;
            foreach (Pokemon pokemon in trainer.Collection)
            {
                if (pokemon.Element == element)
                {
                    contains = true;
                }
            }

            if (contains)
            {
                trainer.Badges++;
            }
            else
            {
                
                for (int index = 0; index < trainer.Collection.Count; index++)
                {
                    var pokemon = trainer.Collection[index];
                    if ((pokemon.Health -= 10) <= 0)
                    {
                        trainer.Collection.RemoveAt(index);
                        index--;
                    }
                }
            }
        }
    }
}