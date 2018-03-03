using System;
using System.Collections.Generic;

class WildFarm
{
    static void Main()
    {
		var animals = new List<Animal>();

		while (true)
		{
			var input = Console.ReadLine();
			if ("End" == input)
			{
				break;
			}

			var animalInput = input.Split();
			var foodInput = Console.ReadLine().Split();
		    var type = animalInput[0];
		    var name = animalInput[1];
		    var weight = double.Parse(animalInput[2]);

		    Animal animal = null;
		    switch (type)
		    {
                case "Cat":
                    animal = new Cat(name, weight, animalInput[3], animalInput[4]);
                    break;
                case "Tiger":
                    animal = new Tiger(name, weight, animalInput[3], animalInput[4]);
                    break;
		        case "Hen":
                    animal = new Hen(name, weight, double.Parse(animalInput[3]));
		            break;
                case "Owl":
                    animal = new Owl(name, weight, double.Parse(animalInput[3]));
                    break;
		        case "Mouse":
		            animal = new Mouse(name, weight, animalInput[3]);
                    break;
                case "Dog":
                    animal = new Dog(name, weight, animalInput[3]);
                    break;
            }

		    var foodType = foodInput[0];
		    var foodQuantity = int.Parse(foodInput[1]);

		    Food food = null;
		    switch (foodType)
		    {
                case "Vegetable":
                    food = new Vegetable(foodQuantity);
                    break;
		        case "Fruit":
                    food = new Fruit(foodQuantity);
		            break;
		        case "Meat":
                    food = new Meat(foodQuantity);
		            break;
		        case "Seeds":
                    food = new Seeds(foodQuantity);
		            break;
            }

		    Console.WriteLine(animal.ProduceSound());

		    try
		    {
		        animal.Feed(food);
            }
		    catch (ArgumentException ae)
		    {
		        Console.WriteLine(ae.Message);
		    }
            animals.Add(animal);
		}

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
	}
}