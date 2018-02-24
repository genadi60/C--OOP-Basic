using System;

public class Car
{
    private string model;
    private decimal fuelAmount;
    private decimal fuelConsumption;
    private int traveledDistance;

    public Car(string model, decimal fuelAmount, decimal fuelConsumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumption = fuelConsumption;
        this.traveledDistance = 0;
    }

    public void CalculateTraveling(int distance)
    {
        if (this.fuelAmount/fuelConsumption < distance)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.traveledDistance += distance;
            this.fuelAmount -= distance * this.fuelConsumption;
        }
    }

    public override string ToString()
    {
        return $"{this.model} {this.fuelAmount:f2} {this.traveledDistance}";
    }
}