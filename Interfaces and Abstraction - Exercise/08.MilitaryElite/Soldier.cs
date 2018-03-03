public abstract class Soldier : ISoldier
{
    private int id;
    private string firstName;
    private string lastName;

    protected Soldier(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string FirstName
    {
        get => firstName;
        set => firstName = value;
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value;
    }

    public virtual void AddPrivate(int id, ISoldier soldier){}
}