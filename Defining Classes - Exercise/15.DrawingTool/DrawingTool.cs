using System;

public class DrawingTool
{
    private int width;
    private int height;
    private string figure;
    private char column = '|';
    private char row = '-';
    public DrawingTool(string figure)
    {
        this.figure = figure;
        this.ExtractCharacteristics();
        this.DrawFigure();
    }
    
    private void ExtractCharacteristics()
    {
        switch (this.figure)
        {
            case "Square":
                var size = int.Parse(Console.ReadLine());
                this.width = size;
                this.height = size;
                break;
            case "Rectangle":
                this.width = int.Parse(Console.ReadLine());
                this.height = int.Parse(Console.ReadLine());
                break;
        }
    }

    private void DrawFigure()
    {
        for (int rIndex = 0; rIndex < this.height; rIndex++)
        {
            var horizontalChar = ' ';
            if (rIndex == 0 || rIndex == height - 1)
            {
                horizontalChar = row;
            }

            var rowSize = this.width + 2;
            for (int cIndex = 0; cIndex < rowSize; cIndex++)
            {
                var verticalChar = horizontalChar;
                if (cIndex == 0 || cIndex == rowSize - 1)
                {
                    verticalChar = column;
                }

                Console.Write(verticalChar);
            }

            Console.WriteLine();
        }
    }
}