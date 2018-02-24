using System.Collections.Generic;
using System.Text;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public Team(string name)
    {
        Name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    public IReadOnlyCollection<Person> FirstTeam
    {
        get => firstTeam;
    }

    public IReadOnlyCollection<Person> ReserveTeam
    {
        get => reserveTeam;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public void AddPlayer(Person player)
    {
        if (player.Age < 40)
        {
            this.firstTeam.Add(player);
        }
        else
        {
            this.reserveTeam.Add(player);
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First team have {FirstTeam.Count} players");
        sb.AppendLine($"Reserve team have {ReserveTeam.Count} players");
        return sb.ToString().Trim();
    }
}