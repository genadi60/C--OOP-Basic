using System.Text;

public class Frog : Animal
{
    public Frog(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return "Ribbit";
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