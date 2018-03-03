using System;

public class Owl : Bird
{
	public Owl(string name, double weight, double wingSize)
		: base(name, weight, wingSize)
	{
	}
	
	public override string ProduceSound()
	{
		return "Hoot Hoot";
	}

    public override void Feed(Food food)
    {
        var foodType = food.GetTypeSubclassType().ToString();
        if (foodType != "Meat")
        {
            throw new ArgumentException($"{GetType()} does not eat {foodType}!");
        }
        Weight += food.Quantity * 0.25;
        FoodEaten += food.Quantity;
    }

    public override string ToString()
	{
		return $"{GetType()} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
	}
}