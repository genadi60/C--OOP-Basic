using System.ComponentModel;

public abstract class Driver
{
    private string name;
    private double totalTime;
    private Car car;
    private double fuelConsumptionPerKm;
    private double speed;

    protected Driver(string name, double totalTime, Car car, double fuelConsumptionPerKm)
    {
        this.Name = name;
        this.TotalTime = totalTime;
        this.Car = car;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        CalculateSpeed();
    }

    public string Name
    {
        get => name;
        private set => name = value;
    }

    public double TotalTime
    {
        get => totalTime;
        private set => totalTime = value;
    }

    public Car Car
    {
        get => car;
        private set => car = value;
    }

    public double FuelConsumptionPerKm
    {
        get => fuelConsumptionPerKm;
        private set => fuelConsumptionPerKm = value;
    }

    public double Speed
    {
        get => speed;
        protected set => speed = value;
    }

    private void CalculateSpeed()
    {
        Speed = (Car.Hp + Car.Tyre.Degradation) / Car.FuelAmount;
    }
}