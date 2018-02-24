public abstract class Animal : IAnimal
{
    private string name;
    private int age;
    private string gender;

    protected Animal(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public string Name
    {
        get => name;
        private set => name = value;
    }

    public int Age
    {
        get => age;
        private set => age = value;
    }

    public string Gender
    {
        get => gender;
        private set => gender = value;
    }

    public virtual string ProduceSound()
    {
        return "";
    }
}