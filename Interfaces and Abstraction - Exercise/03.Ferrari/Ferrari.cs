public class Ferrari : Car, IFerrari
{
    private const string MODEL = "488-Spider";

    public Ferrari(string driver)
        : base(MODEL, driver)
    {
    }


    public string PushBrakes()
    {
        return "Brakes!";
    }

    public string PushGasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{base.Model}/{PushBrakes()}/{PushGasPedal()}/{base.Driver}";
    }
}