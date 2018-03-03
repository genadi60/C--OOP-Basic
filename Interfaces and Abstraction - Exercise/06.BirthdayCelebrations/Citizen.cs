using System;

public abstract class Citizen : ICitizen
{
    private string name;

    protected Citizen(string name)
    {
        Name = name;
    }

    private string Name
    {
        get => name;
        set => name = value;
    }

    public virtual string GetBirthday()
    {
        return String.Empty;
    }
}