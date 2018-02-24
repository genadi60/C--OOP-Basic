public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double[] coordinates;

    public Rectangle(string id, double width, double height, double horizontal, double vertical)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.coordinates = new double[2];
        this.coordinates[0] = horizontal;
        this.coordinates[1] = vertical;
    }

    public string Id
    {
        get => id;
    }

    public double Width
    {
        get => width;
    }

    public double Height
    {
        get => height;
    }

    public double[] Coordinates
    {
        get => coordinates;
    }

    public bool CheckIntersection(Rectangle rectangle)
    {
        var x1 = this.coordinates[0];
        var y1 = this.coordinates[1];
        var x2 = rectangle.coordinates[0];
        var y2 = rectangle.coordinates[1];
        var w1 = this.width;
        var h1 = this.height;
        var w2 = rectangle.width;
        var h2 = rectangle.height;

        if ((x1 + w1) < x2 || (x2 + w2) < x1 || (y1 - h1) > y2 || (y2 - h2) > y1)
        {
            return false;
        }
        return true;
    }
}