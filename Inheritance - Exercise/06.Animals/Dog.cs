using System.Text;

public class Dog : Animal
{
    public Dog(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return "Woof!";
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