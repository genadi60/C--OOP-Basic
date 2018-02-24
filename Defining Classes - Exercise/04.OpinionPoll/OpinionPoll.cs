using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OpinionPoll
{
    class OpinionPoll
    {
        static void Main()
        {
            var numberOfPersons = int.Parse(Console.ReadLine());
            var filter = 30;
            var family = new Family();
            for (int counter = 0; counter < numberOfPersons; counter++)
            {
                var personData = Console.ReadLine().Split();
                var name = personData[0];
                var age = int.Parse(personData[1]);
                var person = new Person(name, age);
                family.AddMember(person);
            }

            foreach (KeyValuePair<string, Person> person in 
                family.Members.Where(x => x.Value.Age > filter).OrderBy(x => x.Value.Name))
            {
                Console.WriteLine(person.Value);
            }
        }
    }
}
