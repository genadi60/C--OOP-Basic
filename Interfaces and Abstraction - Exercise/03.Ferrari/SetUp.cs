using System;

class SetUp
{
    static void Main()
    {
        var driverName = Console.ReadLine();
        IFerrari ferrari = new Ferrari(driverName);
        Console.WriteLine(ferrari);
    }
}