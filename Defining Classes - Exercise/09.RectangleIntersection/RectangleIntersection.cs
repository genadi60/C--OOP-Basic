using System;
using System.Collections.Generic;
using System.Linq;

class RectangleIntersection
{
    static void Main()
    {
        var rectangles = new Dictionary<string, Rectangle>();
        var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int counter = 0; counter < commands[0]; counter++)
        {
            var rectangleTokens = Console.ReadLine().Split();
            var id = rectangleTokens[0];
            var width = double.Parse(rectangleTokens[1]);
            var height = double.Parse(rectangleTokens[2]);
            var horizontal = double.Parse(rectangleTokens[3]);
            var vertical = double.Parse(rectangleTokens[4]);
            if (!rectangles.ContainsKey(id))
            {
                rectangles[id] = new Rectangle(id, width, height, horizontal, vertical);
            }
        }

        for (int index = 0; index < commands[1]; index++)
        {
            var rectanglePair = Console.ReadLine().Split();
            if (rectangles.ContainsKey(rectanglePair[0]))
            {
                var firstRectangle = rectangles[rectanglePair[0]];
                if (rectangles.ContainsKey(rectanglePair[1]))
                {
                    var secondRectangle = rectangles[rectanglePair[1]];
                    Console.WriteLine(firstRectangle.CheckIntersection(secondRectangle).ToString().ToLower());
                }
            }
        }
    }
}