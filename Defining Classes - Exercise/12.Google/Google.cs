using System;
using System.Collections.Generic;
using System.Linq;

class Google
{
    private static Dictionary<string, Person> people = new Dictionary<string, Person>();
    static void Main()
    {
        while (true)
        {
            var input = Console.ReadLine();
            if ("End" == input)
            {
                break;
            }

            var tokens = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var command = tokens[1];
            SelectMethodAndRegister(command, tokens);
        }

        PrintInformation(Console.ReadLine());
    }

    private static void SelectMethodAndRegister(string command, string[] tokens)
    {
        switch (command)
        {
            case "company":
                RegisterCompany(tokens);
                break;
            case "car":
                RegisterCar(tokens);
                break;
            case "pokemon":
                RegisterPokemon(tokens);
                break;
            case "parents":
                RegisterParent(tokens);
                break;
            case "children":
                RegisterChild(tokens);
                break;
        }
    }

    private static void PrintInformation(string personName)
    {
        var person = people[personName];
        Console.WriteLine(person);
    }

    private static void RegisterChild(string[] tokens)
    {
        var personName = tokens[0];
        if (!people.ContainsKey(personName))
        {
            people[personName] = new Person(personName);
        }
        var child = new Child(tokens[2], tokens[3]);
        people[personName].Children.Add(child);
    }

    private static void RegisterParent(string[] tokens)
    {
        var personName = tokens[0];
        if (!people.ContainsKey(personName))
        {
            people[personName] = new Person(personName);
        }
        var parent = new Parent(tokens[2], tokens[3]);
        people[personName].Parents.Add(parent);
    }

    private static void RegisterPokemon(string[] tokens)
    {
        var personName = tokens[0];
        if (!people.ContainsKey(personName))
        {
            people[personName] = new Person(personName);
        }
        var pokemon = new Pokemon(tokens[2], tokens[3]);
        people[personName].Pokemons.Add(pokemon);
    }

    private static void RegisterCar(string[] tokens)
    {
        var personName = tokens[0];
        if (!people.ContainsKey(personName))
        {
            people[personName] = new Person(personName);
        }
        var car = new Car(tokens[2], int.Parse(tokens[3]));
        people[personName].Car = car;
    }

    private static void RegisterCompany(string[] tokens)
    {
        var personName = tokens[0];
        if (!people.ContainsKey(personName))
        {
            people[personName] = new Person(personName);
        }
        var company = new Company(tokens[2], tokens[3], decimal.Parse(tokens[4]));
        people[personName].Company = company;
    }
}