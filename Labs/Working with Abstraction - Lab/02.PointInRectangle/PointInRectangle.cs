using System;

class PointInRectangle
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle(Console.ReadLine());
        var pointsNumber = int.Parse(Console.ReadLine());
        for (int index = 0; index < pointsNumber; index++)
        {
            Console.WriteLine(rectangle.CalculatePointPosition(Console.ReadLine()));
        }
    }
}