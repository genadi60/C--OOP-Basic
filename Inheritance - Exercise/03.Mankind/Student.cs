using System.Text;

public class Student : Human
{
	private string facultyNumber;

	public Student(string firstName, string lastName, string facultyNumber)
		:base(firstName, lastName)
	{
		FacultyNumber = Validator.ValidateFacultyNumber(facultyNumber);
	}

	private string FacultyNumber
	{
		get { return facultyNumber; }
		set { facultyNumber = value; }
	}

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Faculty number: {FacultyNumber}");
        return sb.ToString();
    }
}