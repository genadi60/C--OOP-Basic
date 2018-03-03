public class Citizen : IPerson
{
    private string name;
    private int age;

    public Citizen(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name
    {
        get => this.name;
        private set => this.name = value;

    }

    public int Age
    {
        get => this.age;
        private set => this.age = value;
    }
}