using System;
using System.Collections.Generic;

class SpeedRacing
{
    static void Main()
    {
        var cars = new Dictionary<string, Car>();
        var carsNumber = int.Parse(Console.ReadLine());
        for (int counter = 0; counter < carsNumber; counter++)
        {
            var carData = Console.ReadLine().Split();
            var model = carData[0];
            var amountOfFuel = decimal.Parse(carData[1]);
            var consumPerKm = decimal.Parse(carData[2]);
            if (!cars.ContainsKey(model))
            {
                cars[model] = new Car(model, amountOfFuel, consumPerKm);
            }
        }

        while (true)
        {
            var input = Console.ReadLine();
            if ("End" == input)
            {
                break;
            }

            var commandData = input.Split();
            var command = commandData[0];
            var model = commandData[1];
            var distance = int.Parse(commandData[2]);
            var car = cars[model];
            car.CalculateTraveling(distance);
        }

        foreach (KeyValuePair<string, Car> kvp in cars)
        {
            Console.WriteLine(kvp.Value);
        }
    }
}