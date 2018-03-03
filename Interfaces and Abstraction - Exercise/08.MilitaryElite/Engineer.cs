using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    private List<IRepair> repairs;

    public Engineer(int id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        Repairs = new List<IRepair>();
    }

    private List<IRepair> Repairs
    {
        get => repairs;
        set => repairs = value;
    }


    public void AddRepair(IRepair repair)
    {
        Repairs.Add(repair);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}")
            .AppendLine($"Corps: {Corps}")
            .AppendLine("Repairs:");
        if (Repairs.Count > 0)
        {
            foreach (var repair in Repairs)
            {
                sb.AppendLine($"  {repair}");
            }
        }
        return sb.ToString().Trim();
    }
}