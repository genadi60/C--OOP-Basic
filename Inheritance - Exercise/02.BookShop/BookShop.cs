using System;

class BookShop
{
    static void Main()
    {
        try
        {
            var author = Console.ReadLine();
            var title = Console.ReadLine();
            var price = decimal.Parse(Console.ReadLine());

            var book = new Book(title, author, price);
            var goldenEditionBook = new GoldenEditionBook(title, author, price);

            Console.WriteLine(book);
            Console.WriteLine(goldenEditionBook);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }

    }
}