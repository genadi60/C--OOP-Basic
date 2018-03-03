using System;

public abstract class Food
{
	private int quantity;

    protected Food(int quantity)
    {
        Quantity = quantity;
    }

    public virtual Type GetTypeSubclassType()
    {
        return null;
    }

    public int Quantity
    {
        get => quantity;
        private set => quantity = value;
    }
}