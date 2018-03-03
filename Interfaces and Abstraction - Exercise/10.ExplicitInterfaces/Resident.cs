public class Resident : ICitizen
{
	private string name;
	private string country;

	public Resident(string name, string country)
	{
		Name = name;
		Country = country;
	}

	private string Country
	{
		get { return country; }
		set { country = value; }
	}


	private string Name
	{
		get { return name; }
		set { name = value; }
	}


	public string GetName()
	{
		return "Mr/Ms/Mrs " + Name;
	}
}