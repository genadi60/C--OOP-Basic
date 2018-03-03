public class Person : Citizen
{
    private string id;
    private string birthday;

    public Person(string name, int age, string id, string birthday)
        : base(name, age)
    {
        Id = id;
        Birthday = birthday;
    }

    private string Birthday
    {
        get => birthday;
        set => birthday = value;
    }

    private string Id
    {
        get => id;
        set => id = value;
    }

    public override void BuyFood()
    {
        base.Food += 10;
    }
}