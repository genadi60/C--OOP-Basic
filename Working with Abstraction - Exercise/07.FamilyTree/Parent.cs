using System.Collections.Generic;

public class Parent
{
    private string name;
    private string birthday;
    private List<Parent> parents;
    private List<Child> children;

    public Parent()
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

    public override string ToString()
    {
        return $"{this.Name} {this.Birthday}";
    }
}