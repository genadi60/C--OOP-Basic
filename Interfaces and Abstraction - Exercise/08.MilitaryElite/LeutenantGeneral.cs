using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    private Dictionary<int, IPrivate> privates;

    

    public LeutenantGeneral(int id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName, salary)
    {
        Privates = new Dictionary<int, IPrivate>();
    }

    public Dictionary<int, IPrivate> Privates
    {
        get => privates;
        set => privates = value;
    }

    public void AddPrivate(int id, IPrivate soldier)
    {
        if (!Privates.ContainsKey(id))
        {
            Privates[id] = soldier;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}")
            .AppendLine("Privates:");
        if (Privates.Count > 0)
        {
            foreach (var soldier in Privates.Values)
            {
                sb.AppendLine($"  {soldier}");
            }
        }
        return sb.ToString().Trim();
    }
}