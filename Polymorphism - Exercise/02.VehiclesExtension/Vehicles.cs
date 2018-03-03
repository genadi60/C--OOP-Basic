using System;
using System.Text;

class Vehicles
{
    static void Main()
    {
		var sb = new StringBuilder();
		IVehicle vehicle1 = null;
		IVehicle vehicle2 = null;
		IVehicle vehicle3 = null;
		
		var carData = Console.ReadLine().Split();
		var fuelQuantity = double.Parse(carData[1]);
		var consum = double.Parse(carData[2]);
		var tankCapacity = double.Parse(carData[3]);
		if (fuelQuantity > tankCapacity)
		{
			//Console.WriteLine($"Cannot fit {fuelQuantity} fuel in the tank");
			fuelQuantity = 0.0;
		}
		vehicle1 = new Car(fuelQuantity, consum, tankCapacity);
		
		var truckData = Console.ReadLine().Split();
		fuelQuantity = double.Parse(truckData[1]);
		consum = double.Parse(truckData[2]);
		tankCapacity = double.Parse(truckData[3]);
		if (fuelQuantity > tankCapacity)
		{
			//Console.WriteLine($"Cannot fit {fuelQuantity} fuel in the tank");
			fuelQuantity = 0.0;
		}
		vehicle2 = new Truck(fuelQuantity, consum, tankCapacity);
		
		var busData = Console.ReadLine().Split();
		fuelQuantity = double.Parse(busData[1]);
		consum = double.Parse(busData[2]);
		tankCapacity = double.Parse(busData[3]);
		if (fuelQuantity > tankCapacity)
		{
			//Console.WriteLine($"Cannot fit {fuelQuantity} fuel in the tank");
			fuelQuantity = 0.0;
		}
		vehicle3 = new Bus(fuelQuantity, consum, tankCapacity);
		
		var actionCounts = int.Parse(Console.ReadLine());
		for (int index = 0; index < actionCounts; index++)
        {
			IVehicle vehicle = null;
			var commands = Console.ReadLine().Split();
            var command = commands[0];
            var type = commands[1];
			var value = double.Parse(commands[2]);
			switch (type)
			{
				case "Car":
					vehicle = vehicle1;
					break;
				case "Truck":
					vehicle = vehicle2;
					break;
				case "Bus":
					vehicle = vehicle3;
					break;
				default:
					break;
			}
			
			switch (command)
            {
                case "Drive":
                    vehicle.Drive(value);
                    break;
                case "Refuel":
					vehicle.Refuel(value);
					break;
				case "DriveEmpty":
					vehicle.DriveEmpty(value);
					break;
            }
        }

        sb.AppendLine(vehicle1.ToString())
            .AppendLine(vehicle2.ToString())
			.AppendLine(vehicle3.ToString());
        Console.WriteLine(sb.ToString());
    }
}