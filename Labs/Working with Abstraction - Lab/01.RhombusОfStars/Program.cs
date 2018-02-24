using System;

class Program
{
    static void Main()
    {
        var size = int.Parse(Console.ReadLine());
        for (int i = 0; i < size; i++)
        {
            PrintRow(size, i);
        }

        for (int i = size - 2; i >= 0; i--)
        {
            PrintRow(size, i);
        }
        
    }

    private static void PrintRow(int size, int row)
    {
        for (int i = 0; i < size - row - 1; i++)
        {
            Console.Write(' ');
        }

        for (int i = 0; i < row + 1; i++)
        {
            Console.Write('*');
            Console.Write(' ');
        }

        Console.WriteLine();
    }
}