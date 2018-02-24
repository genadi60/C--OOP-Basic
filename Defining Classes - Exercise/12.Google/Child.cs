using System;
using System.Globalization;

public class Child
{
    private string name;
    private DateTime birthday;

    public Child(string name, string birthday)
    {
        this.name = name;
        this.Birthday = birthday;
    }

    public string Birthday
    {
        get => $"{birthday:dd}/{birthday:MM}/{birthday:yyyy}";
        set => birthday = DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture);

    }

    public override string ToString()
    {
        return $"{this.name} {this.Birthday}";
    }
}