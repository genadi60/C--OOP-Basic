using System.Linq;

public class Rectangle
{
    public Point TopLeft { get; private set; }
    public Point BottomRight { get; private set; }

    public Rectangle(string input)
    {
        var token = input.Trim().Split().Select(int.Parse).ToArray();

        TopLeft = new Point(token[0], token[1]);
        BottomRight = new Point(token[2], token[3]);
    }

    public bool CalculatePointPosition(string input)
    {
        var token = input.Trim().Split().Select(int.Parse).ToArray();
        Point point = new Point(token[0], token[1]);
        if (point.X >= TopLeft.X && point.X <= BottomRight.X && point.Y >= TopLeft.Y && point.Y <= BottomRight.Y)
        {
            return true;
        }

        return false;
    }
}