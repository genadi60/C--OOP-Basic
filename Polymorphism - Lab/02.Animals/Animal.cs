using System;

public abstract class Animal
{
    private string name;
    private string favoriteFood;

    public Animal(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavoriteFood = favoriteFood;
    }

    public string Name
    {
        get => name;
        private set => name = value;
    }

    public string FavoriteFood
    {
        get => favoriteFood;
        private set => favoriteFood = value;
    }

    public virtual string ExplainSelf()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavoriteFood}";
    }
}