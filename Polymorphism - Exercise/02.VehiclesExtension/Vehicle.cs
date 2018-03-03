using System;

public abstract class Vehicle : IVehicle
{
    private double fuelQuantity;
    private double consumptionPerKm;
	private double tankCapacity;

	protected Vehicle(double fuelQuantity, double consumptionPerKm, double tankCapacity)
    {
        ConsumptionPerKm = consumptionPerKm;
		TankCapacity = tankCapacity;
		FuelQuantity = fuelQuantity;
	}

	public double TankCapacity
	{
		get { return tankCapacity; }
		set { tankCapacity = value; }
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

    public virtual void Drive(double distance) {}

	public virtual void DriveEmpty(double distance) {}

    public virtual void Refuel(double fuel){}
}