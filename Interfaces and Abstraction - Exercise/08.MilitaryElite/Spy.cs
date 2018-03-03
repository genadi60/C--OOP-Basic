using System.Text;

public class Spy : Soldier, ISpy
{
    private int spyCodeNumber;

    public Spy(int id, string firstName, string lastName, int spyCodeNumber)
        : base(id, firstName, lastName)
    {
        SpyCodeNumber = spyCodeNumber;
    }

    private int SpyCodeNumber
    {
        get => spyCodeNumber;
        set => spyCodeNumber = value;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}")
            .AppendLine($"Code Number: {SpyCodeNumber}");
        return sb.ToString().Trim();
    }
}