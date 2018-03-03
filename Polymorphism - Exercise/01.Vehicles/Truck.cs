using System;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double consumptionPerKm) : base(fuelQuantity, consumptionPerKm)
    {
    }

    public override string Drive(double distance)
    {
        var consumption = ConsumptionPerKm;
        if (!base.IsSummer())
        {
            consumption += 1.6;
        }

        var fuelForDistance = consumption * distance;
        if (fuelForDistance > FuelQuantity)
        {
            return $"{GetType()} needs refueling";
        }
        else
        {
            FuelQuantity -= fuelForDistance;
            return $"{GetType()} travelled {distance} km";
        }
    }

    public override void Refuel(double fuel)
    {
        FuelQuantity += fuel * 0.95;
    }

    public override string ToString()
    {
        return $"{GetType()}: {FuelQuantity:f2}";
    }
}