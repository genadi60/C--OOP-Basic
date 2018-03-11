public abstract class Tyre
{
    private string name;
    private double hardness;
    private double degradation;

    protected Tyre(string name, double hardness, double degradation)
    {
        this.Name = name;
        this.Hardness = hardness;
        this.Degradation = degradation;
    }

    public string Name
    {
        get => name;
        private set => name = value;
    }

    public double Hardness
    {
        get => hardness;
        private set => hardness = value;
    }

    public double Degradation
    {
        get => degradation;
        private set => degradation = value;
    }
}