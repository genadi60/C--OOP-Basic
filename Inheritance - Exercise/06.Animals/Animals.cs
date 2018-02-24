class Animals
{
    static void Main()
    {
        IAnimalFactory animalFactory = new AnimalFactory();
        animalFactory.CreateAnimal();
    }
}