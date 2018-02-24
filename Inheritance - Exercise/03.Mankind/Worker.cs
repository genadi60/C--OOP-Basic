using System.Text;

public class Worker : Human
{
	private decimal weekSalary;
	private decimal workHoursPerDay;

	public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
		: base(firstName, lastName)
	{
	    WeekSalary = Validator.ValidateWeekSalary(weekSalary);
	    WorkHoursPerDay = Validator.ValidateWorkingHours(workHoursPerDay);
	}

	private decimal WorkHoursPerDay
	{
		get { return workHoursPerDay; }
		set { workHoursPerDay = value; }
	}


	private decimal WeekSalary
	{
		get { return weekSalary; }
		set { weekSalary = value; }
	}

	public override string ToString()
	{
		var sb = new StringBuilder();
	    var salaryPerHour = CalculateSalaryPerHour();
	    sb.AppendLine(base.ToString());
        sb.AppendLine($"Week Salary: {WeekSalary:f2}");
		sb.AppendLine($"Hours per day: {WorkHoursPerDay:f2}");
		sb.AppendLine($"Salary per hour: {salaryPerHour:f2}");
		return sb.ToString();
	}

	private decimal CalculateSalaryPerHour()
	{
		return WeekSalary / (5.0m * WorkHoursPerDay);
	}
}