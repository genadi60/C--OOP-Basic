using System.IO;

public class Box : IBox
{
    private double length;
    private double width;
    private double hight;

    public Box(params double[] parameters)
    {
        Length = parameters[0] > 0 ? parameters[0] : throw new InvalidDataException("Length cannot be zero or negative.");
        Width = parameters[1] > 0 ? parameters[1] : throw new InvalidDataException("Width cannot be zero or negative."); ;
        Hight = parameters[2] > 0 ? parameters[0] : throw new InvalidDataException("Height cannot be zero or negative."); ;
    }

    private double Length
    {
        get => length;
        set => length = value;
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
        return  Length * Width * 2 + (Length + Width) * Hight * 2;
    }

    public double CalculateLateralSurfaceArea()
    {
        return (Length + Width) * Hight * 2;
    }

    public double CalculateVolume()
    {
        return Length * Width * Hight;
    }
}