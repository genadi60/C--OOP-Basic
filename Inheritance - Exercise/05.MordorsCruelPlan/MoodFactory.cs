public class MoodFactory
{
    private string mood;

    public MoodFactory(int value)
    {
        Mood = CdeateMood(value);
    }

    public string Mood
    {
        get => mood;
        private set => mood = value;
    }

    private string CdeateMood(int value)
    {
        if (value < -5)
        {
            return "Angry";
        }

        if (value <= 0)
        {
            return "Sad";
        }

        if (value <= 15)
        {
            return "Happy";
        }

        if (value > 15)
        {
            return "JavaScript";
        }

        return null;
    }

    public override string ToString()
    {
        return $"{Mood}";
    }
}