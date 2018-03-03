using System;

public abstract class Vehicle : IVehicle
{
    private double fuelQuantity;
    private double consumptionPerKm;

    protected Vehicle(double fuelQuantity, double consumptionPerKm)
    {
        FuelQuantity = fuelQuantity;
        ConsumptionPerKm = consumptionPerKm;
    }

    public double FuelQuantity
    {
        get => fuelQuantity;
        set => fuelQuantity = value;
    }

    public double ConsumptionPerKm
    {
        get => consumptionPerKm;
        private set => consumptionPerKm = value;
    }

    public virtual string Drive(double distance)
    {
        return String.Empty;
    }

    public virtual void Refuel(double fuel) {}

    public bool IsSummer()
    {
        var date = DateTime.Now;
        if (date.Month > 5 && date.Month < 9)
        {
            return true;
        }

        return false;
    }
}