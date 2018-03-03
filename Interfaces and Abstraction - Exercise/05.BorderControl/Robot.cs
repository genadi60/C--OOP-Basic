public class Robot : ICitizen
{
    private string model;
    private string id;

    public Robot(string model, string id)
    {
        Model = model;
        Id = id;
    }

    private string Model
    {
        get => model;
        set => model = value;
    }

    private string Id
    {
        get => id;
        set => id = value;
    }

    public string GetId()
    {
        return Id;
    }
}