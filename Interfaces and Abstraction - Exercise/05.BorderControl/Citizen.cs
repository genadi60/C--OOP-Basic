public class Citizen : ICitizen
{
    private string name;
    private int age;
    private string id;

    public Citizen(string name, int age, string id)
    {
        Name = name;
        Age = age;
        Id = id;
    }

    private string Name
    {
        get => name;
        set => name = value;
    }

    private int Age
    {
        get => age;
        set => age = value;
    }

    string Id
    {
        get => id;
        set => id = value;
    }

    public string GetId()
    {
        return Id;
    }
}