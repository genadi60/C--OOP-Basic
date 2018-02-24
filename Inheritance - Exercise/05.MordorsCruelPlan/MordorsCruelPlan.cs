using System;
class MordorsCruelPlan
{
    static void Main()
    {
        FoodFactory foodFactory = new FoodFactory();
        MoodFactory moodFactory = new MoodFactory(foodFactory.Health);
        Console.WriteLine(foodFactory);
        Console.WriteLine(moodFactory);
    }
}