using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var matrixSize = ExtractValues(Console.ReadLine());
        var matrix = CreateMatrix(matrixSize);
        var sum = 0L;
        while (true)
        {
            var command = Console.ReadLine();
            if ("Let the Force be with you" == command)
            {
                break;
            }
            var positionIvo = ExtractValues(command);
            var positionEvil = ExtractValues(Console.ReadLine());
            DestroyEvil(positionEvil, matrixSize, matrix);
            sum += CollectStarsIvo(positionIvo, matrixSize, matrix);
            
        }
 
        Console.WriteLine(sum);
    }

    private static long[,] CreateMatrix(int[] matrixSize)
    {
        int row = matrixSize[0];
        int col = matrixSize[1];

        long[,] matrix = new long[row,col];

        int value = 0;
        for (int rIndex = 0; rIndex < row; rIndex++)
        {
            for (int cIndex = 0; cIndex < col; cIndex++)
            {
                matrix[rIndex,cIndex] = value++;
            }
        }

        return matrix;
    }

    private static long CollectStarsIvo(int[] position,int[] matrixSize, long[,] matrix)
    {
        var sum = 0L;
        if (position[0] > matrixSize[0])
        {
            position[1] += position[0] - matrixSize[0];
            position[0] = matrixSize[0];
        }

        if (position[1] < -1)
        {
            position[0] -= -1 - position[1];
            position[1] = -1;
        }
        int rowIvo = position[0];
        int colIvo = position[1];

        while (rowIvo >= 0 && colIvo < matrixSize[1])
        {
            if (rowIvo >= 0 && rowIvo < matrixSize[0] && colIvo >= 0 && colIvo < matrixSize[1])
            {
                sum += matrix[rowIvo, colIvo];
            }
            colIvo++;
            rowIvo--;
        }
        return sum;
    }

    private static void DestroyEvil(int[] position, int[] matrixSize, long[,] matrix)
    {
        if (position[0] > matrixSize[0])
        {
            position[1] -= position[0] - matrixSize[0];
            position[0] = matrixSize[0];
        }

        if (position[1] > matrixSize[1])
        {
            position[0] -= position[1] - matrixSize[1];
            position[1] = matrixSize[1];
        }
        int rowEvil = position[0];
        int colEvil = position[1];

        while (rowEvil >= 0 && colEvil >= 0)
        {
            if (rowEvil >= 0 && rowEvil < matrixSize[0] && colEvil >= 0 && colEvil < matrixSize[1])
            {
                matrix[rowEvil, colEvil] = 0;
            }
            rowEvil--;
            colEvil--;
        }
    }

    private static int[] ExtractValues(string input)
    {
        return input
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}