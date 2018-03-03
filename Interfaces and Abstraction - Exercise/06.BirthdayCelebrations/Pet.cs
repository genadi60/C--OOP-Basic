public class Pet : Citizen
{
    
    private string birthday;

    public Pet(string name, string birthday)
        : base(name)
    {
        Birthday = birthday;
    }

    private string Birthday
    {
        get => birthday;
        set => birthday = value;
    }


    public override string GetBirthday()
    {
        return Birthday;
    }
}