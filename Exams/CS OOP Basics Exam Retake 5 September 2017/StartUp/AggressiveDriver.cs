public class AggressiveDriver : Driver
{
    private const double AggressiveFuelConsumption = 2.7;

    public AggressiveDriver(string name, double totalTime, Car car)
        : base(name, totalTime, car, AggressiveFuelConsumption)
    {
        base.Speed *= 1.3;
    }
}