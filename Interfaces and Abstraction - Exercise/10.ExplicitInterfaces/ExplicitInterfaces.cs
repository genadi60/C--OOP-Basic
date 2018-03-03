using System;

class ExplicitInterfaces
{
    static void Main()
    {
		while (true)
		{
			var personInput = Console.ReadLine();
			if ("End" == personInput)
			{
				break;
			}

			var personData = personInput.Split();
			var name = personData[0];
			var country = personData[1];
			var age = int.Parse(personData[2]);
			ICitizen person = new Person(name, age);
			ICitizen resident = new Resident(name, country);
			Console.WriteLine(person.GetName());
			Console.WriteLine(resident.GetName());
		}
    }
}