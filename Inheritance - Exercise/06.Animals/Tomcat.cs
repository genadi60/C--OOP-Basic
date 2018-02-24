using System.Text;

public class Tomcat : Cat
{
    private const string TOMCAT_GENDER = "Male";

    public Tomcat(string name, int age, string gender) : base(name, age, TOMCAT_GENDER)
    {
    }

    public override string ProduceSound()
    {
        return "MEOW";
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