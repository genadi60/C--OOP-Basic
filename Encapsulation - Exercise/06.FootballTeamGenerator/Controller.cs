using System;
using System.Collections.Generic;

public class Controller : IController
{
	private Dictionary<string, Team> teams;
    
	public Controller(InputReader reader, OutputWriter writer)
	{
		Teams = new Dictionary<string, Team>();
    }

    public Dictionary<string, Team> Teams
    {
        get => teams;
        set => teams = value;
    }

    public void CreateTeam(string[] data)
    {
        var teamName = data[1];
	    if (!Teams.ContainsKey(teamName))
	    {
	        Teams[teamName] = new Team(teamName);
        }
	}

	public Player CreatePlayer(string[] data)
	{
	    var playerName = data[2];
        return new Player(playerName, CreateStats(data));
	}

	public Stats CreateStats(string[] data)
	{
	    var endurance = int.Parse(data[3]);
	    var sprint = int.Parse(data[4]);
	    var dribble = int.Parse(data[5]);
	    var passing = int.Parse(data[6]);
	    var shooting = int.Parse(data[7]);
        return new Stats(endurance, sprint, dribble, passing, shooting);
    }

    public void AddPlayer(string[] data)
    {
        var teamName = data[1];
        if (!Teams.ContainsKey(teamName))
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }
        Teams[teamName].AddPlayer(CreatePlayer(data));
    }

    public void RemovePlayer(string[] data)
    {
        var teamName = data[1];
        var playerName = data[2];
        if (!Teams[teamName].Players.ContainsKey(playerName))
        {
            throw new ArgumentException($"Player {playerName} is not in {teamName} team.");
        }
        Teams[teamName].RemovePlayer(playerName);
    }

    public string RatingTeam(string[] data)
    {
        var teamName = data[1];
        if (!Teams.ContainsKey(teamName))
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }
        return Teams[teamName].ToString();
    }
}