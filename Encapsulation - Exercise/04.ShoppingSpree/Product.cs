using System;
using System.IO;

public class Product
{
    private string name;
    private decimal cost;

    public Product(string name, decimal cost)
    {
        Name = String.IsNullOrEmpty(name)? throw new InvalidDataException("Name cannot be empty") : name;
        Cost = cost >= 0 ? cost : throw new InvalidDataException("Money cannot be negative");

    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public decimal Cost
    {
        get => cost;
        set => cost = value;
    }
}