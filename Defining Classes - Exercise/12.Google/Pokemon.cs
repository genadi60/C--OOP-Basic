public class Pokemon
{
    private string name;
    private string element;

    public Pokemon(string name, string element)
    {
        this.name = name;
        this.element = element;
    }

    public override string ToString()
    {
        return $"{this.name} {this.element}";
    }
}