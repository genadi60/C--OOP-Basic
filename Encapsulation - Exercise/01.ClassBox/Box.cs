public class Box : IBox
{
    private double lendth;
    private double width;
    private double hight;

    public Box(params double[] parameters)
    {
        Lendth = parameters[0];
        Width = parameters[1];
        Hight = parameters[2];
    }

    private double Lendth
    {
        get => lendth;
        set => lendth = value;
    }

    private double Width
    {
        get => width;
        set => width = value;
    }

    private double Hight
    {
        get => hight;
        set => hight = value;
    }

    public double CalculateSurfaceArea()
    {
        return  Lendth * Width * 2 + (Lendth + Width) * Hight * 2;
    }

    public double CalculateLateralSurfaceArea()
    {
        return (Lendth + Width) * Hight * 2;
    }

    public double CalculateVolume()
    {
        return Lendth * Width * Hight;
    }
}