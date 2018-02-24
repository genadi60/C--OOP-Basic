using System;
using System.Collections.Generic;

public class Topping
{
    private const double BASE_CALORIES_PER_GRAM = 2.0;
    private Dictionary<string, double> constants = 
        new Dictionary<string, double>()
        {
            ["meat"] = 1.2,
            ["veggies"] = 0.8,
            ["cheese"] = 1.1,
            ["sauce"] = 0.9
        };

    private double weight;
    private string type;
    private double calories;

    public Topping(string type, double weight)
    {
        Type = type;
        Weight = weight; 
        Calories = CalculateCalories();
    }

    public double Calories
    {
        get => calories;
        private set => calories = value;
    }

    private string Type
    {
        get => type;
        set => type = !constants.ContainsKey(value.ToLower()) ? throw new ArgumentException($"Cannot place {value} on top of your pizza.") : value;
    }

    private double Weight
    {
        get => weight;
        set => weight = (value < 1 || value > 50) ? throw new ArgumentException($"{Type} weight should be in the range [1..50].") : value;

    }

    private double CalculateCalories()
    {
        var multyplier = this.constants[Type.ToLower()];
        return BASE_CALORIES_PER_GRAM * multyplier * weight;
    }
}