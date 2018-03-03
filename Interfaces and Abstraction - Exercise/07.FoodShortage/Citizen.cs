using System;

public abstract class Citizen : IBuyer
{
    private string name;
    private int age;
    private int food = 0;

    protected Citizen(string name, int age)
    {
        Name = name;
        Age = age;
    }

    private int Age
    {
        get => age;
        set => age = value;
    }

    private string Name
    {
        get => name;
        set => name = value;
    }

    public virtual void BuyFood()
    {
        
    }

    public int Food { get; set; }
}