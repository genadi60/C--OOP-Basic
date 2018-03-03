public abstract class Car
{
    private string model;
    private string driver;

    protected Car(string model, string driver)
    {
        Model = model;
        Driver = driver;
    }

    public string Model
    {
        get => model;
        private set => model = value;
    }

    public string Driver
    {
        get => driver;
        private set => driver = value;
    }
}