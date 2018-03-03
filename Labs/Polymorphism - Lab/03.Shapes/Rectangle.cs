public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public double Height
    {
        get => height;
        private set => height = value;
    }

    public double Width
    {
        get => width;
        private set => width = value;
    }


    public override double CalculatePerimeter()
    {
        var result = (this.Height + this.Width) * 2;
        return result;
    }

    public override double CalculateArea()
    {
        var result = this.Height * this.Width;
        return result;
    }

    public sealed override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}