using System;

public abstract class Animal
{
	private string name;
	private double weight;
	private int foodEaten;

	protected Animal(string name, double weight)
	{
		Name = name;
		Weight = weight;
		FoodEaten = 0;
	}

	public string Name { get => name; private set => name = value; }
	public double Weight { get => weight; set => weight = value; }
	public int FoodEaten { get => foodEaten; set => foodEaten = value; }

    public virtual void Feed(Food food) {}

    public virtual string ProduceSound()
	{
		return String.Empty;
	}
}