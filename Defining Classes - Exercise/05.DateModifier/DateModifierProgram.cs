using System;

class DateModifierProgram
{
    static void Main()
    {
        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();
        var difference = new DateModifier();
        difference.CalculateDifference(firstDate, secondDate);
        Console.WriteLine(difference);
    }
}