public class Person : ICitizen
{
	private string name;
	private int age;

	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	}

	private int Age
	{
		get { return age; }
		set { age = value; }
	}


	private string Name
	{
		get { return name; }
		set { name = value; }
	}


	public string GetName()
	{
		return Name;
	}
}