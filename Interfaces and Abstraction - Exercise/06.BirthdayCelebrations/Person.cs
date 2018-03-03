public class Person : Citizen
{
    private int age;
    private string id;
    private string birthday;

    public Person(string name, int age, string id, string birthday)
        : base(name)
    {
        Age = age;
        Id = id;
        Birthday = birthday;
    }

    private string Birthday
    {
        get => birthday;
        set => birthday = value;
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


    public override string GetBirthday()
    {
        return Birthday;
    }
}