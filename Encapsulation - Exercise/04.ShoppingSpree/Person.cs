using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Person
{
    private string name;
    private decimal money;
    private List<string> bagOfProducts;

    public Person(string name, decimal money)
    {
        Name = String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name) ? throw new InvalidDataException("Name cannot be empty") : name;
        Money = money >= 0 ? money : throw new InvalidDataException("Money cannot be negative");
        BagOfProducts = new List<string>();
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public decimal Money
    {
        get => money;
        set => money = value;
    }

    public List<string> BagOfProducts
    {
        get => bagOfProducts;
        set => bagOfProducts = value;
    }

    public bool BuyingProduct(Product product)
    {
        if (Money >= product.Cost)
        {
            Money -= product.Cost;
            BagOfProducts.Add(product.Name);
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{Name} - ").Append(bagOfProducts.Count == 0 ? "Nothing bought" : String.Join(", ", BagOfProducts));
        return sb.ToString().Trim();
    }
}