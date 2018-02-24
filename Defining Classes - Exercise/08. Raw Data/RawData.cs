using System;
using System.Collections.Generic;
using System.Linq;

class RawData
{
    static void Main()
    {
        var cars = new Dictionary<string, LinkedList<Car>>();
        var carsNumber = int.Parse(Console.ReadLine());
        for (int counter = 0; counter < carsNumber; counter++)
        {
            var inputData = Console.ReadLine().Split();
            var model = inputData[0];
            var speed = int.Parse(inputData[1]);
            var power = int.Parse(inputData[2]);
            var weight = int.Parse(inputData[3]);
            var type = inputData[4];
            var tireList = new List<Tire>();
            for (int i = 0; i < 8; i += 2)
            {
                var pressure = double.Parse(inputData[5 + i]);
                var age = int.Parse(inputData[5 + i + 1]);
                var tire = new Tire(pressure, age);
                tireList.Add(tire);
            }
            var engine = new Engine(speed, power);
            var cargo = new Cargo(weight, type);
            var car = new Car(model, engine, tireList, cargo);
            if (!cars.ContainsKey(type))
            {
                cars[type] = new LinkedList<Car>();
            }
            cars[type].AddLast(car);
        }
        var target = Console.ReadLine();
        var targetCars = cars[target];
        foreach (Car car in targetCars)
        {
            if ("fragile" == target)
            {
                foreach (Tire tire in car.Tires)
                {
                    if (tire.Pressure < 1)
                    {
                        Console.WriteLine(car);
                        break;
                    }
                }
            }
            else
            {
                if (car.Engine.Power > 250)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}