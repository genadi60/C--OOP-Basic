using System;

public class Dog : Mammal
{
	public Dog(string name, double weight, string livingRegion)
		: base(name, weight, livingRegion)
	{
	}
	
	public override string ProduceSound()
	{
		return "Woof!";
	}

    public override void Feed(Food food)
    {
        var foodType = food.GetTypeSubclassType().ToString();
        if (foodType != "Meat")
        {
            throw new ArgumentException($"{GetType()} does not eat {foodType}!");
        }
        Weight += food.Quantity * 0.4;
        FoodEaten += food.Quantity;
    }

    public override string ToString()
	{
		return $"{ GetType()} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
	}
}