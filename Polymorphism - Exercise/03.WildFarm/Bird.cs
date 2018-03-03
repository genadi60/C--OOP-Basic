public abstract class Bird : Animal
{
	private double wingSize;

	protected Bird(string name, double weight, double wingSize) : base(name, weight)
	{
		WingSize = wingSize;
	}

	public double WingSize { get => wingSize; private set => wingSize = value; }
}