using System;
using System.Collections.Generic;
using System.Linq;

class CarSalesman
{
    static void Main()
    {
        var engines = new Dictionary<string, Engine>();
        var carsList = new LinkedList<Car>();
        var enginesNumber = int.Parse(Console.ReadLine());
        for (int index = 0; index < enginesNumber; index++)
        {
            var engineTokens = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries);
            var model = engineTokens[0];
            var power = engineTokens[1];
            var displacement = "n/a";
            var efficiency = "n/a";
            if (engineTokens.Length == 3)
            {
                var temp = 0.0;
                if (double.TryParse(engineTokens[2], out temp))
                {
                    displacement = engineTokens[2];
                }
                else
                {
                    efficiency = engineTokens[2];
                }
            }

            if (engineTokens.Length == 4)
            {
                displacement = engineTokens[2];
                efficiency = engineTokens[3];
            }

            if (!engines.ContainsKey(model))
            {
                engines[model] = new Engine(model, power, displacement, efficiency);
            }
        }

        var carsNumber = int.Parse(Console.ReadLine());
        for (int index = 0; index < carsNumber; index++)
        {
            var carTokens = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries);
            var model = carTokens[0];
            var engineModel = carTokens[1];
            var weight = "n/a";
            var color = "n/a";
            if (carTokens.Length == 3)
            {
                var temp = 0.0;
                if (double.TryParse(carTokens[2], out temp))
                {
                    weight = carTokens[2];
                }
                else
                {
                    color = carTokens[2];
                }
            }

            if (carTokens.Length == 4)
            {
                weight = carTokens[2];
                color = carTokens[3];
            }

            var engine = engines[engineModel];
            var car = new Car(model, engine, weight, color);
            carsList.AddLast(car);

        }

        foreach (var car in carsList)
        {
            Console.WriteLine(car);
        }
    }
}