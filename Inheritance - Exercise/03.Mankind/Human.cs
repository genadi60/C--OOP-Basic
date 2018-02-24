using System.Text;

public class Human
{
	private string firstName;
	private string lastName;

	public Human(string firstName, string lastName)
	{
        FirstName = Validator.ValidateFirstName(firstName);
	    LastName = Validator.ValidateLastName(lastName);
    }


	private string LastName
	{
		get { return lastName; }
		set { lastName = value; }
	}


	private string FirstName
	{
		get { return firstName; }
		set { firstName = value; }
	}

	public override string ToString()
	{
	    var sb = new StringBuilder();
	    sb.AppendLine($"First Name: {FirstName}");
	    sb.AppendLine($"Last Name: {LastName}");
        return sb.ToString().Trim();
	}
}