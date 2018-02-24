using System;

public class Player
{
    private string name;
    private Stats stats;
    
    public Player(string name, Stats stats)
    {
        Name = (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name)) ? throw new ArgumentException("A name should not be empty.") : name;
        Stats = stats;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public Stats Stats
    {
        get => stats;
        set => stats = value;
    }
}