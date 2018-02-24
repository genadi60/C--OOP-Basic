using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private Company company; 
    private Car car;
    private List<Pokemon> pokemons;
    private List<Parent> parents;
    private List<Child> children;

    public Person(string name)
    {
        this.name = name;
        this.company = null;
        this.car = null;
        this.pokemons = new List<Pokemon>();
        this.parents = new List<Parent>();
        this.children = new List<Child>();
    }

    public Company Company
    {
        set => company = value;
    }

    public Car Car
    {
        set => car = value;
    }

    public List<Pokemon> Pokemons
    {
        get => pokemons;
        set => pokemons = value;
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
        sb.AppendLine(this.name);
        sb.AppendLine("Company:");
        if (this.company != null)
        {
            sb.AppendLine(this.company.ToString());
        }
        sb.AppendLine("Car:");
        if (this.car != null)
        {
            sb.AppendLine(this.car.ToString());
        }

        sb.AppendLine("Pokemon:");
        if (this.pokemons.Count > 0)
        {
            foreach (Pokemon pokemon in this.pokemons)
            {
                sb.AppendLine(pokemon.ToString());
            }
        }

        sb.AppendLine("Parents:");
        if (this.parents.Count > 0)
        {
            foreach (var parent in this.parents)
            {
                sb.AppendLine(parent.ToString());
            }
        }
        sb.AppendLine("Children:");
        if (this.children.Count > 0)
        {
            foreach (var child in this.children)
            {
                sb.AppendLine(child.ToString());
            }
        }
        return sb.ToString().Trim();
    }
}
