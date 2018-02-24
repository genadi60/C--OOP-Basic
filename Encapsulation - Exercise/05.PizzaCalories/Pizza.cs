using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private double totalCalories;
    private List<Topping> toppings;
    private Dough dough;

    public Pizza(string name)
    {
        Name = name;
        Toppings = new List<Topping>();
    }

    private List<Topping> Toppings
    {
        get => toppings;
        set => toppings = value;
    }

    public Dough Dough
    {
        get => dough;
        set => dough = value;
    }
    
    private double Calories
    {
        get => totalCalories;
        set => totalCalories = value;
    }

    public void AddTopping(Topping topping)
    {
        if (Toppings.Count == 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
        Toppings.Add(topping);
    }

    private string Name
    {
        get => name;
        set => name = (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) || value.Length > 15 || value.Length < 1) ? throw new ArgumentException("Pizza name should be between 1 and 15 symbols.") : value;
    }
    
    private void CalculateCalories()
    {
        Calories = Toppings.Count > 0 ? Toppings.Select(t => t.Calories).Sum() + Dough.Calories : Dough.Calories;
    }

    public override string ToString()
    {
		CalculateCalories();
		return $"{Name} - {Calories:f2} Calories.";
    }
}