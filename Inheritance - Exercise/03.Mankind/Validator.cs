using System;
using System.Text.RegularExpressions;


public class Validator
{
	private const int FIRST_NAME_MIN_LENGTH = 4;
    private const int LAST_NAME_MIN_LENGHT = 3;
    private const string FIRST_NAME = "firstName";
    private const string LAST_NAME = "lastName";
    private const int FACULTY_NUMBER_MIN_LENGTH = 5;
    private const int FACULTY_NUMBER_MAX_LENGTH = 10;
    private const decimal WEEK_SALARY_MIN_LIMIT = 10m;
    private const decimal WORKING_HOURS_MIN_LIMIT = 1m;
    private const decimal WORKING_HOURS_MAX_LIMIT = 12m;
    private const string WEEK_SALARY = "weekSalary";
    private const string WORKING_HOURS_PER_DAY = "workHoursPerDay";
    
    public static string ValidateFirstName(string firstName)
	{
		if (!Char.IsUpper(firstName[0]))
		{
			throw new ArgumentException($"Expected upper case letter! Argument: { FIRST_NAME }");

        }
		if (firstName.Length < FIRST_NAME_MIN_LENGTH)
		{
			throw new ArgumentException($"Expected length at least {FIRST_NAME_MIN_LENGTH} symbols! Argument: {FIRST_NAME}");
		}
		return firstName;
	}
    
	public static string ValidateLastName(string lastName)
	{
		if (!Char.IsUpper(lastName[0]))
		{
			throw new ArgumentException($"Expected upper case letter! Argument: {LAST_NAME}");
		}
		if (lastName.Length < LAST_NAME_MIN_LENGHT)
		{
			throw new ArgumentException($"Expected length at least {LAST_NAME_MIN_LENGHT} symbols! Argument: {LAST_NAME}");
		}
		return lastName;
	}

    public static string ValidateFacultyNumber(string value)
    {
        var pattern = @"\W";
        var regex = new Regex(pattern);
        var match = regex.Match(value);
        var valueLength = value.Length;
        if (valueLength < FACULTY_NUMBER_MIN_LENGTH || valueLength > FACULTY_NUMBER_MAX_LENGTH || match.Length > 0)
        {
            throw new ArgumentException("Invalid faculty number!");
        }

        return value;
    }

    public static decimal ValidateWeekSalary(decimal value)
    {
        if (value <= WEEK_SALARY_MIN_LIMIT)
        {
            throw new ArgumentException($"Expected value mismatch! Argument: {WEEK_SALARY}");
        }

        return value;
    }

    public static decimal ValidateWorkingHours(decimal value)
    {
        if (value < WORKING_HOURS_MIN_LIMIT || value > WORKING_HOURS_MAX_LIMIT)
        {
            throw new ArgumentException($"Expected value mismatch! Argument: {WORKING_HOURS_PER_DAY}");
        }

        return value;
    }
}