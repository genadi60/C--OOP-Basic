public class HardTyre : Tyre
{
    private const string HardTyreName = "Hard";

    public HardTyre(double hardness, double degradation)
        : base(HardTyreName, hardness, degradation)
    {
    }
}