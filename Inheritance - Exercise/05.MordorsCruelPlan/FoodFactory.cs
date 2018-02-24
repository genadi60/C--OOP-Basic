using System;

public class FoodFactory
{
    private int health;

    public FoodFactory()
    {
        Health = CalculateHealth();
    }

    public int Health
    {
        get => health;
        private set => health = value;
    }

    private int CalculateHealth()
    {
        var result = 0;
        string[] foods = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
        for (int index = 0; index < foods.Length; index++)
        {
            switch (foods[index].ToLower())
            {
                case "cram":
                    result += 2;
                    break;
                case "lembas":
                    result += 3;
                    break;
                case "apple":
                    result += 1;
                    break;
                case "melon":
                    result += 1;
                    break;
                case "honeycake":
                    result += 5;
                    break;
                case "mushrooms":
                    result -= 10;
                    break;
                default:
                    result -= 1;
                    break;
            }
        }
        return result;
    }

    public override string ToString()
    {
        return $"{Health}";
    }
}