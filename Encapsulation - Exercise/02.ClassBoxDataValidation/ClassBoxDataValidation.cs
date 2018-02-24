using System;
using System.Reflection;

class ClassBoxDataValidation
{
    static void Main()
    {
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

        var parametersOfBox = new double[3];
        for (int index = 0; index < parametersOfBox.Length; index++)
        {
            parametersOfBox[index] = double.Parse(Console.ReadLine());
        }
        IBox box = null;
        try
        {
            box = new Box(parametersOfBox);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        Console.WriteLine("Surface Area - {0:f2}", box.CalculateSurfaceArea());
        Console.WriteLine("Lateral Surface Area - {0:f2}", box.CalculateLateralSurfaceArea());
        Console.WriteLine("Volume - {0:f2}", box.CalculateVolume());
    }
}