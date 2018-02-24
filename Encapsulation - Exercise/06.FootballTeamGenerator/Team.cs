using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private Dictionary<string, Player> players;
    private int rating;

    public Team(string name)
    {
        Name = (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name)) ? throw new ArgumentException("A name should not be empty.") : name;
        Players = new Dictionary<string, Player>();
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public Dictionary<string, Player> Players
    {
        get => players;
        set => players = value;
    }

    public int Rating
    {
        get => rating;
        set => rating = value;
    }

    public void AddPlayer(Player player)
    {
        if (!Players.ContainsKey(player.Name))
        {
            Players[player.Name] = player;
        }
    }

    public void RemovePlayer(string playerName)
    {
        Players.Remove(playerName);
    }

    private void CalculateRating()
    {
        var sum = 0L;
        if (Players.Count > 0)
        {
            foreach (var item in Players.Values.Select(x => x.Stats))
            {
                sum += item.Endurance + item.Sprint + item.Dribble + item.Passing + item.Shooting;
            }
            Rating = (int)Math.Round(sum / (Players.Count * 5.0));
        }
        else
        {
            Rating = 0;
        }

    }

    public override string ToString()
    {
        CalculateRating();
        return $"{Name} - {Rating}";
    }
}