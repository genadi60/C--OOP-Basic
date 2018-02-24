using System.Collections.Generic;

public class Child
{
    private string name;
    private string birthday;
    private List<Parent> parents;
    private List<Child> children;

    public Child()
    {
        this.parents = new List<Parent>();
        this.children = new List<Child>();
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Birthday
    {
        get => birthday;
        set => birthday = value;
    }

    public List<Parent> Parents
    {
        get => parents;
        set => parents = value;
    }

    public List<Child> Children
    {
        get => children;
        set => children = value;
    }
}