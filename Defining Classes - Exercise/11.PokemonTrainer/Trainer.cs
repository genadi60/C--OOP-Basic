using System.Collections.Generic;

public class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> collection;

    public Trainer(string name)
    {
        this.name = name;
        this.badges = 0;
        this.collection = new List<Pokemon>();
    }

    public string Name
    {
        get => name;
    }

    public int Badges
    {
        get => badges;
        set => badges = value;
    }

    public List<Pokemon> Collection
    {
        get => collection;
        set => collection = value;
    }
}