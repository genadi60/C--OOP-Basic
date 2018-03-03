using System;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double consumptionPerKm, double tankCapacity) : base(fuelQuantity, consumptionPerKm, tankCapacity)
    {
    }

    public override void Drive(double distance)
    {
        var consumption = ConsumptionPerKm + 1.6;
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
		else if (fuel * 0.95 > (TankCapacity - FuelQuantity))
		{
			Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
		}
		else
		{
			FuelQuantity += fuel * 0.95;
		}
	}

    public override string ToString()
    {
        return $"{GetType()}: {FuelQuantity:f2}";
    }
}