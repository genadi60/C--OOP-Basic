using System;
using System.Collections.Generic;

public class Dough
{
    
    const double BASE_CALORIES_PER_GRAM = 2.0;
    private Dictionary<string, double> constants =
        new Dictionary<string, double>()
        {
            ["white"] = 1.5,
            ["wholegrain"] = 1.0,
            ["crispy"] = 0.9,
            ["chewy"] = 1.1,
            ["homemade"] = 1.0 
        };
    
    private double weight;
    private string flourType;
    private string bakingTechnique;
    private double calories;
    
    public Dough(string flourType, string bakingTechnique, double weight)
    {
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
        Calories = CalculateCalories();
    }

    public double Calories
    {
        get => calories;
        private set => calories = value;
    }

    private string FlourType
    {
        get => flourType;
        set => flourType = constants.ContainsKey(value.ToLower()) ? value : throw new ArgumentException("Invalid type of dough.");
    }

    private string BakingTechnique
    {
        get => bakingTechnique;
        set => bakingTechnique = constants.ContainsKey(value.ToLower()) ? value : throw new ArgumentException("Invalid type of dough.");

    }

    private double Weight
    {
        get => weight;
        set => weight = (value < 1 || value > 200) ? throw new ArgumentException("Dough weight should be in the range [1..200].") : value;
    }

    private  double CalculateCalories()
    {
        var bakingTechniqueMultyplier = constants[BakingTechnique.ToLower()];
        var flourTypeMultyplier = constants[FlourType.ToLower()];
        return BASE_CALORIES_PER_GRAM * flourTypeMultyplier * bakingTechniqueMultyplier * Weight;
    }
}