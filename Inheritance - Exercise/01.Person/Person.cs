using System;
using System.Text;

public class Person
{
    private string name;
    private int age;

    protected Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual string Name
    {
        get => name;
        set => name = value.Length < 3 ? throw new ArgumentException("Name's length should not be less than 3 symbols!") : value;
    }

    public virtual int Age
    {
        get => age;
        set => age = value < 0 ? throw new ArgumentException("Age must be positive!") : value;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(String.Format("Name: {0}, Age: {1}", Name, Age));
        return sb.ToString();
    }
}