using System;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        FirstName = firstName.Length < 3 ? throw new ArgumentException("First name cannot be less than 3 symbols") : firstName;
        LastName = lastName.Length < 3 ? throw new ArgumentException("Last name cannot be less than 3 symbols") : lastName; ;
        Age = age <= 0 ? throw new ArgumentException("Age cannot be zero or negative integer") : age;
        Salary = salary < 460m ? throw new ArgumentException("Salary cannot be less than 460 leva") : salary;
    }

    public decimal Salary
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
}