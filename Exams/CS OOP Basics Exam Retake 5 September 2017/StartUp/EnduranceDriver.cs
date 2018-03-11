public class EnduranceDriver : Driver
{
    private const double EnduranceFuelConsumption = 1.5;

    public EnduranceDriver(string name, double totalTime, Car car)
        : base(name, totalTime, car, EnduranceFuelConsumption)
    {
    }
}