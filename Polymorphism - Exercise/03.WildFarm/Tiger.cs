using System;

public class Tiger : Feline
{
	public Tiger(string name, double weight, string livingRegion, string breed)
		: base(name, weight, livingRegion, breed)
	{
	}
	
	public override string ProduceSound()
	{
		return "ROAR!!!";
	}

    public override void Feed(Food food)
    {
        var foodType = food.GetTypeSubclassType().ToString();
        if (foodType != "Meat")
        {
            throw new ArgumentException($"{GetType()} does not eat {foodType}!");
        }
        Weight += food.Quantity;
        FoodEaten += food.Quantity;
    }

    public override string ToString()
	{
		return $"{GetType()} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
	}
}