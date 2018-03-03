using System;

public class Mouse : Mammal
{
	public Mouse(string name, double weight, string livingRegion)
		: base(name, weight, livingRegion)
	{
	}
	
	public override string ProduceSound()
	{
		return "Squeak";
	}

    public override void Feed(Food food)
    {
        var foodType = food.GetTypeSubclassType().ToString();
        if (foodType != "Fruit" && foodType != "Vegetable")
        {
            throw new ArgumentException($"{GetType()} does not eat {foodType}!");
        }

        Weight += food.Quantity * 0.1;
        FoodEaten += food.Quantity;
    }

    public override string ToString()
	{
		return $"{ GetType()} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
	}
}