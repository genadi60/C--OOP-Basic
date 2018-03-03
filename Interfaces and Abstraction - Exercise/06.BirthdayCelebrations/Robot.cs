public class Robot : Citizen
{
    private string id;

    public Robot(string model, string id)
            : base(model)
    {
        Id = id;
    }

    private string Id
    {
        get => id;
        set => id = value;
    }
}