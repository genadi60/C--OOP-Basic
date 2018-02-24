using System;
using System.Collections.Generic;

class FamilyTree
{
    static void Main()
    {
        var parentsList = new List<string>();
        var childrenList = new List<string>();
        var persons = new Dictionary<string, Person>();
        var targetPerson = Console.ReadLine();
        
        while (true)
        {
            var input = Console.ReadLine();
            if ("End" == input)
            {
                break;
            }
            
            if (input.Contains("-"))            //Separate storing children and parents
            {
                var tokens = input.Split(" - ");
                var parent = tokens[0];
                var child = tokens[1];
                parentsList.Add(parent);
                childrenList.Add(child);
            }
            else                                 //Storing all persons
            {                                   
                var name = input.Substring(0, input.LastIndexOf(' '));
                var birthday = input.Substring(input.LastIndexOf(' ') + 1);
                
                if (!persons.ContainsKey(name))
                {
                    persons[name] = new Person();
                }

                persons[name].Name = name;
                persons[name].Birthday = birthday;
            }
        }

        for (int i = 0; i < parentsList.Count; i++) //Set to "Person" all in parentList and childrenList
        {
            var parent = new Parent();
            var child = new Child();

            if (IsDate(parentsList[i]))
            {
                foreach (Person person in persons.Values)
                {
                    if (parentsList[i] == person.Birthday)
                    {
                        parent.Name = person.Name;
                        parent.Birthday = person.Birthday;
                    }

                    if (IsDate(targetPerson))       //If targetPerson = date => targetPerson = name
                    {
                        if (targetPerson == person.Birthday)
                        {
                            targetPerson = person.Name;
                        }
                    }
                }
            }
            else
            {
                foreach (Person person in persons.Values)
                {
                    if (parentsList[i] == person.Name)
                    {
                        parent.Name = person.Name;
                        parent.Birthday = person.Birthday;
                    }
                }
            }

            if (IsDate(childrenList[i]))
            {
                foreach (Person person in persons.Values)
                {
                    if (childrenList[i] == person.Birthday)
                    {
                        child.Name = person.Name;
                        child.Birthday = person.Birthday;
                    }
                }
            }
            else
            {
                foreach (Person person in persons.Values)
                {
                    if (childrenList[i] == person.Name)
                    {
                        child.Name = person.Name;
                        child.Birthday = person.Birthday;
                    }
                }
            }

            parent.Children.Add(child);
            child.Parents.Add(parent);

            foreach (Person person in persons.Values)
            {
                if (parent.Name == person.Name)
                {
                    person.Children.Add(child);
                }

                if (child.Name == person.Name)
                {
                    person.Parents.Add(parent);
                }
            }
        }

        foreach (KeyValuePair<string, Person> kvp in persons)
        {
            if (targetPerson == kvp.Key)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }

    private static bool IsDate(string target)
    {
        if (Char.IsDigit(target[0]))
        {
            return true;
        }
        return false;
    }
}