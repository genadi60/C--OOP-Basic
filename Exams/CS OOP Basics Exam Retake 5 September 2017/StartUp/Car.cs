public class Car
{
    private const double MaximumTankCapacity = 160.0;

    private int hp;
    private double fuelAmount;
    private Tyre tyre;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }

    public int Hp
    {
        get => hp;
        set => hp = value;
    }

    public double FuelAmount
    {
        get => fuelAmount;
        private set => fuelAmount = (value + fuelAmount) > MaximumTankCapacity ? MaximumTankCapacity : value;
    }

    public Tyre Tyre
    {
        get => tyre;
        set => tyre = value;
    }
}