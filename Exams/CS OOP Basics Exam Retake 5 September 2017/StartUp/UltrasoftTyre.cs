public class UltrasoftTyre : Tyre
{
    private double grip;

    public UltrasoftTyre(string name, double hardness, double degradation, double grip)
        : base(name, hardness, degradation)
    {
        this.Grip = grip;
    }

    public double Grip
    {
        get => grip;
        private set => grip = value;
    }
}