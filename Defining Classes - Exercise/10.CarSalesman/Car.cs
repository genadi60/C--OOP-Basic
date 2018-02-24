using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private string weight;
    private string color;

    public Car(string model, Engine engine, string weight, string color)
    {
        this.model = model;
        this.engine = engine;
        this.weight = weight;
        this.color = color;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.model}:");
        sb.AppendLine($"  {this.engine.Model}:");
        sb.AppendLine($"    Power: {this.engine.Power}");
        sb.AppendLine($"    Displacement: {this.engine.Displacement}");
        sb.AppendLine($"    Efficiency: {this.engine.Efficiency}");
        sb.AppendLine($"  Weight: {this.weight}");
        sb.AppendLine($"  Color: {this.color}");
        return sb.ToString().Trim();
    }
}
