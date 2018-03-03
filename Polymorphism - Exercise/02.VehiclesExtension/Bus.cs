using System;

public class Bus : Vehicle
{
	public Bus(double fuelQuantity, double consumptionPerKm, double tankCapacity) : base(fuelQuantity, consumptionPerKm, tankCapacity)
	{
	}

	public override void Drive(double distance)
	{
		var consumption = ConsumptionPerKm + 1.4;
		var fuelForDistance = consumption * distance;
		if (fuelForDistance > FuelQuantity)
		{
			Console.WriteLine($"{GetType()} needs refueling");
		}
		else
		{
			FuelQuantity -= fuelForDistance;
			Console.WriteLine($"{GetType()} travelled {distance} km");
		}
	}

	public override void DriveEmpty(double distance)
	{
		var consumption = ConsumptionPerKm;
		var fuelForDistance = consumption * distance;
		if (fuelForDistance > FuelQuantity)
		{
			Console.WriteLine($"{GetType()} needs refueling");
		}
		else
		{
			FuelQuantity -= fuelForDistance;
			Console.WriteLine($"{GetType()} travelled {distance} km");
		}
	}

	public override void Refuel(double fuel)
	{

		if (fuel <= 0)
		{
			Console.WriteLine("Fuel must be a positive number");
		}
		else if (fuel > (TankCapacity - FuelQuantity))
		{
			Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
		}
		else
		{
			FuelQuantity += fuel;
		}

	}

	public override string ToString()
	{
		return $"{GetType()}: {FuelQuantity:f2}";
	}
}