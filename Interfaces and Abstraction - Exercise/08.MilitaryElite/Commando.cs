using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{
    private List<IMission> missions;

    public Commando(int id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        Missions = new List<IMission>();
    }

    private List<IMission> Missions
    {
        get => missions;
        set => missions = value;
    }


    public void AddMission(IMission mission)
    {
        Missions.Add(mission);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}")
            .AppendLine($"Corps: {Corps}")
            .AppendLine("Missions:");
        if (Missions.Count > 0)
        {
            foreach (var mission in Missions)
            {
                sb.AppendLine($"  {mission}");
            }
        }
        return sb.ToString().Trim();
    }
}