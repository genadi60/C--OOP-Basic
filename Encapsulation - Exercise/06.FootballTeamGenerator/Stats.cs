using System;

public class Stats
{
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
    {
        Endurance = (endurance < 0 || endurance > 100) ? throw new ArgumentException("Endurance should be between 0 and 100.") : endurance;
        Sprint = (sprint < 0 || sprint > 100) ? throw new ArgumentException("Sprint should be between 0 and 100.") : sprint;
        Dribble = (dribble < 0 || dribble > 100) ? throw new ArgumentException("Dribble should be between 0 and 100.") : dribble;
        Passing = (passing < 0 || passing > 100) ? throw new ArgumentException("Passing should be between 0 and 100.") : passing;
        Shooting = (shooting < 0 || shooting > 100) ? throw new ArgumentException("Shooting should be between 0 and 100.") : shooting;
    }

    public int Endurance
    {
        get => endurance;
        set => endurance = value;
    }

    public int Sprint
    {
        get => sprint;
        set => sprint = value;
    }

    public int Dribble
    {
        get => dribble;
        set => dribble = value;
    }

    public int Passing
    {
        get => passing;
        set => passing = value;
    }

    public int Shooting
    {
        get => shooting;
        set => shooting = value;
    }
}