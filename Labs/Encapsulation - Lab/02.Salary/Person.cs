public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    public double Salary
    {
        get => salary;
        set => salary = value;
    }

    public string FirstName
    {
        get => firstName;
        set => firstName = value;
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public void IncreaseSalary(double bonus)
    {
        if (Age > 30)
        {
            Salary += Salary * bonus / 100.0;
        }
        else
        {
            Salary += Salary * bonus / 200.0;
        }
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} receives {Salary:f2} leva.";
    }
}