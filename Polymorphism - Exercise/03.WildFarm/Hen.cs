public class Hen : Bird
{
	public Hen(string name, double weight, double wingSize)
		: base(name, weight, wingSize)
	{
	}
	
	public override string ProduceSound()
	{
		return "Cluck";
	}

    public override void Feed(Food food)
    {
        Weight += food.Quantity * 0.35;
        FoodEaten += food.Quantity;
    }

    public override string ToString()
	{
		return $"{GetType()} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
	}
}