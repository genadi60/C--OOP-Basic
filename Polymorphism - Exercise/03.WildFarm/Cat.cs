using System;

public class Cat : Feline
{
	public Cat(string name, double weight, string livingRegion, string breed)
		: base(name, weight, livingRegion, breed)
	{
	}
	
	public override string ProduceSound()
	{
		return "Meow";
	}

    public override void Feed(Food food)
    {
        var foodType = food.GetTypeSubclassType().ToString();
        if (foodType != "Meat" && foodType != "Vegetable")
        {
            throw new ArgumentException($"{GetType()} does not eat {foodType}!");
        }
        Weight += food.Quantity * 0.3;
        FoodEaten += food.Quantity;
    }

    public override string ToString()
	{
		return $"{GetType()} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
	}
}