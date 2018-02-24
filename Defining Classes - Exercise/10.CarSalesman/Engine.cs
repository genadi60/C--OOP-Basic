using System.Text;

public class Engine
{
    private string model;
    private string power;
    private string displacement;
    private string efficiency;

    public Engine(string model, string power, string displacement, string efficiency)
    {
        this.model = model;
        this.power = power;
        this.displacement = displacement;
        this.efficiency = efficiency;
    }

    public string Model
    {
        get => model;
    }

    public string Power
    {
        get => power;
    }

    public string Displacement
    {
        get => displacement;
    }

    public string Efficiency
    {
        get => efficiency;
    }
}

