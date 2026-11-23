
using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Question 1
        string title = "clean code";
        string upperTitle = title.ToUpper();
        Console.WriteLine(title);
        Console.WriteLine(upperTitle);


        // Question 2
        string book1 = "Clean Code";
        string book2 = "Clean Code";
        Console.WriteLine(ReferenceEquals(book1, book2));


        // Question 3
        StringBuilder sb = new StringBuilder();
        sb.Append("Book List");
        sb.Append(" - Updated");
        Console.WriteLine(sb);


        // Question 4
        sb.Replace("Book List", "Library");
        Console.WriteLine(sb);


        // Question 5
        title = "Clean Code";
        int pages = 464;
        string result = "Book: " + title + ", Pages: " + pages;
        Console.WriteLine(result);


        // Question 6
        result = $"Book: {title}, Pages: {pages}";
        Console.WriteLine(result);


        // Question 7
        result = string.Format("Book: {0}, Pages: {1}", title, pages);
        Console.WriteLine(result);


        // Question 8
        pages = 464;
        if (pages > 300)
        {
            Console.WriteLine("Long Book");
        }
        else
        {
            Console.WriteLine("Short Book");
        }


        // Question 9
        pages = 464;
        bool isAvailable = true;

        if (pages > 300 && isAvailable == true)
        {
            Console.WriteLine("You can borrow this book");
        }


        // Question 10
        title = "Refactoring";

        switch (title)
        {
            case "Clean Code":
                Console.WriteLine("Great choice!");
                break;

            case "Refactoring":
                Console.WriteLine("Nice pick!");
                break;

            default:
                Console.WriteLine("Never heard of it");
                break;
        }


        // Question 11
        pages = 464;
        string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
        Console.WriteLine(sizeLabel);


        // Question 12
        string[] books = {
            "Clean Code",
            "The Pragmatic Programmer",
            "Refactoring"
        };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + books[i]);
        }


        // Question 13
        int j = 0;

        while (j < books.Length)
        {
            Console.WriteLine(books[j]);
            j++;
        }


        // Question 14
        int k = 0;

        do
        {
            Console.WriteLine("Checking book...");
            k++;
        }
        while (k < 3);


        // Question 15
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }


        // Question 16
        foreach (string book in books)
        {
            if (book == "Refactoring")
            {
                break;
            }

            Console.WriteLine(book);
        }


        // Question 17
        foreach (string book in books)
        {
            if (book == "The Pragmatic Programmer")
            {
                continue;
            }

            Console.WriteLine(book);
        }


        // Question 18
        PrintFirstBook(books);
    }

    static void PrintFirstBook(string[] books)
    {
        if (books.Length == 0)
        {
            return;
        }

        Console.WriteLine(books[0]);
    }
}
