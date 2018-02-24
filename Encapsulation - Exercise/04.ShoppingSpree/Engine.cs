using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Engine : IEngine
{
    private InputReader reader;
    private OutputWriter writer;
    private StringBuilder sb;

    public Engine()
    {
        Reader = new InputReader();
        Writer = new OutputWriter();
        this.sb = new StringBuilder();
    }

    private InputReader Reader
    {
        get => reader;
        set => reader = value;
    }

    private OutputWriter Writer
    {
        get => writer;
        set => writer = value;
    }

    public void Run()
    {
        var persons = new Dictionary<string, Person>();
        var products = new Dictionary<string, Product>();
        var personsWithMoney = Reader.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        var productsWithPrice = Reader.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        if (!CreateAllPersons(personsWithMoney, persons))
        {
            return;
        }

        if (!CreateAllProducts(productsWithPrice, products))
        {
            return;
        }

        CheckAllPurchases(persons, products,this.sb);
        Printresult(persons, this.sb);
    }

    private void Printresult(Dictionary<string, Person> persons, StringBuilder sb)
    {
        foreach (var person in persons.Values)
        {
            sb.AppendLine(person.ToString());
        }
        Writer.WriteLine(sb.ToString().Trim());
    }

    private void CheckAllPurchases(Dictionary<string, Person> persons, Dictionary<string, Product> products, StringBuilder sb)
    {
        while (true)
        {
            var input = Reader.ReadLine();
            if ("END" == input)
            {
                break;
            }

            var personAndProduct = input.Trim().Split();
            var personName = personAndProduct[0];
            var productName = personAndProduct[1];
            
            if (persons.ContainsKey(personName))
            {
                if (products.ContainsKey(productName))
                {
                    var product = products[productName];
                    var person = persons[personName];
                    if (person.BuyingProduct(product))
                    {
                        sb.AppendLine($"{personName} bought {productName}");
                    }
                    else
                    {
                        sb.AppendLine($"{personName} can't afford {productName}");
                    }
                }
            }
        }
    }

    private bool CreateAllProducts(string[] productsWithPrice, Dictionary<string, Product> products)
    {
        foreach (var data in productsWithPrice)
        {
            var productData = data.Split(new[] {"="}, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                Product product = new Product(productData[0], decimal.Parse(productData[1]));
                if (!products.ContainsKey(productData[0]))
                {
                    products[productData[0]] = product;
                }
            }
            catch (Exception e)
            {
                Writer.WriteLine(e.Message);
                return false;
            }
        }

        return true;
    }

    private bool CreateAllPersons(string[] personsWithMoney, Dictionary<string, Person> persons)
    {
        foreach (var data in personsWithMoney)
        {
            var personData = data.Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                Person person = new Person(personData[0], decimal.Parse(personData[1]));
                if (!persons.ContainsKey(personData[0]))
                {
                    persons[personData[0]] = person;
                }
            }
            catch (Exception e)
            {
                Writer.WriteLine(e.Message);
                return false;
            }

        }

        return true;
    }
}