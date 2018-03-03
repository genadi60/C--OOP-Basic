public class Rebel : Citizen
{
    private string group;

    public Rebel(string name, int age, string group) 
        : base(name, age)
    {
        Group = group;
    }

    private string Group
    {
        get => group;
        set => group = value;
    }

    public override void BuyFood()
    {
        base.Food += 5;
    }
}