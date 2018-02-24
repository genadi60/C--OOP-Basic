using System.Text;

public class Kitten : Cat
{
    private const string KITTEN_GENDER = "Female"; 

    public Kitten(string name, int age, string gender) : base(name, age, KITTEN_GENDER)
    {
    }

    public override string ProduceSound()
    {
        return "Meow";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(this.GetType().ToString())
            .AppendLine($"{base.Name} {base.Age} {base.Gender}")
            .AppendLine(ProduceSound());
        return sb.ToString().Trim();
    }
}