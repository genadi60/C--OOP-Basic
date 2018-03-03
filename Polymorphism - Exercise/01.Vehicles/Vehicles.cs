using System;
using System.Text;

class Vehicles
{
    static void Main()
    {
        var carData = Console.ReadLine().Split();
        var fuelQuantity = double.Parse(carData[1]);
        var consum = double.Parse(carData[2]);
        IVehicle vehicle1 = new Car(fuelQuantity, consum);
        var truckData = Console.ReadLine().Split();
        fuelQuantity = double.Parse(truckData[1]);
        consum = double.Parse(truckData[2]);
        IVehicle vehicle2 = new Truck(fuelQuantity, consum);
        var actionCounts = int.Parse(Console.ReadLine());
        var sb = new StringBuilder();
        for (int index = 0; index < actionCounts; index++)
        {
            IVehicle vehicle = null;
            var commands = Console.ReadLine().Split();
            var command = commands[0];
            var type = commands[1];
            if ("Car" == type)
            {
                vehicle = vehicle1;
            }
            if ("Truck" == type)
            {
                vehicle = vehicle2;
            }

            switch (command)
            {
                case "Drive":
                    sb.AppendLine(vehicle.Drive(double.Parse(commands[2])));
                    break;
                case "Refuel":
                    vehicle.Refuel(double.Parse(commands[2]));
                    break;
            }
        }

        sb.AppendLine(vehicle1.ToString())
            .AppendLine(vehicle2.ToString());
        Console.WriteLine(sb.ToString());
    }
}