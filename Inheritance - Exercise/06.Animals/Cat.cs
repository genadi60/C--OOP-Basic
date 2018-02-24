using System.Text;

public class Cat : Animal
{
    public Cat(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return "Meow meow";
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