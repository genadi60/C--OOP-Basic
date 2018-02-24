using System;
using System.Linq;
using System.Text;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public string Title
    {
        get => title;
        private set => title = value.Length < 3 ? throw new ArgumentException("Title not valid!") : value;
    }

    public string Author
    {
        get => author;
        private set
        {
            var tokens = value.Split();
            if (tokens.Length > 1)
            {
                if (Char.IsDigit(tokens[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }
            this.author = value;
        }
    }

    public virtual decimal Price
    {
        get => price;
        private set => price = value <= 0 ? throw new ArgumentException("Price not valid!") : value;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Type: ").AppendLine(this.GetType().Name)
            .Append("Title: ").AppendLine(this.Title)
            .Append("Author: ").AppendLine(this.Author)
            .Append("Price: ").Append($"{this.Price:f2}")
            .AppendLine();

        return sb.ToString();
    }

}