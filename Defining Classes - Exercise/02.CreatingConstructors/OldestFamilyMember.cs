using System;

class OldestFamilyMember
{
    static void Main()
    {
        var numberOfPersons = int.Parse(Console.ReadLine());
        var family = new Family();
        for (int counter = 0; counter < numberOfPersons; counter++)
        {
            var personData = Console.ReadLine().Split();
            var name = personData[0];
            var age = int.Parse(personData[1]);
            var person = new Person(name, age);
            family.AddMember(person);
        }

        Console.WriteLine(family.GetOldestMember());
    }
}