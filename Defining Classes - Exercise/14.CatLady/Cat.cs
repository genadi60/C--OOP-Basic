public class Cat
{
    private string name;
    private string breed;
    private string property;

    public Cat(string breed, string name, string property)
    {
        this.name = name;
        this.breed = breed;
        this.property = property;
    }

    public override string ToString()
    {
        if (this.breed == "Cymric")
        {
            var temp = double.Parse(this.property);
            this.property = $"{temp:f2}";
        }
        return $"{this.breed} {this.name} {this.property}";
    }
}