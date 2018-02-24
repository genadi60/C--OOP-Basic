using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private string birthday;
    private List<Parent> parents;
    private List<Child> children;

    public Person()
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
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Name} {this.Birthday}");
        sb.AppendLine("Parents:");
        foreach (Parent parent in Parents)
        {
            sb.AppendLine($"{parent.Name} {parent.Birthday}");
        }

        sb.AppendLine("Children:");
        foreach (Child child in Children)
        {
            sb.AppendLine($"{child.Name} {child.Birthday}");
        }
        return sb.ToString().Trim();
    }
}
