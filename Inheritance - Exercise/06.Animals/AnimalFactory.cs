using System;

public class AnimalFactory : IAnimalFactory
{
    private const string ERROR_MESSAGE = "Invalid input!";

    public void CreateAnimal()
    {
        var animalType = "";
        while ((animalType = Console.ReadLine()) != "Beast!")
        {
            var animalTokens = Console.ReadLine().Split();
            try
            {
                ValidateAnimalData(animalTokens);
                var name = animalTokens[0];
                var age = int.Parse(animalTokens[1]);
                var gender = animalTokens[2];
                Animal animal = null;
                switch (animalType)
                {
                    case "Dog":
                        animal = new Dog(name, age, gender);
                        break;
                    case "Cat":
                        animal = new Cat(name, age, gender);
                        break;
                    case "Frog":
                        animal = new Frog(name, age, gender);
                        break;
                    case "Kitten":
                        animal = new Kitten(name, age, gender);
                        break;
                    case "Tomcat":
                        animal = new Tomcat(name, age, gender);
                        break;
                    default:
                        throw new ArgumentException(ERROR_MESSAGE);
                }

                Console.WriteLine(animal);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            
        }
    }
   

    private static void ValidateAnimalData(string[] tokens)
    {
        if (tokens.Length < 3)
        {
            throw new ArgumentException(ERROR_MESSAGE);
        }

        if (int.Parse(tokens[1]) < 0)
        {
            throw new ArgumentException(ERROR_MESSAGE);
        }

        if ("Male" != tokens[2] && "Female" != tokens[2])
        {
            throw new ArgumentException(ERROR_MESSAGE);
        }
    }
}