using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string Author;
    public string ISBN;
    private bool isAvailable;

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        isAvailable = true;
    }

    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine(Title + " kitabı götürüldü.");
        }
        else
        {
            Console.WriteLine(Title + " kitabı artıq götürülüb!");
        }
    }

    public void ReturnBook()
    {
        isAvailable = true;
        Console.WriteLine(Title + " kitabı qaytarıldı.");
    }

    public void DisplayInfo()
    {
        string status = isAvailable ? "Mövcuddur" : "Götürülüb";
        Console.WriteLine("Kitab: " + Title + " | Müəllif: " + Author + " | Status: " + status);
    }
}

class Program
{
    static void Main()
    {
        List<Book> library = new List<Book>();


        library.Add(new Book("Sword Art Online", "Reki Kawahara", "101"));
        library.Add(new Book("Overlord", "Kugane Maruyama", "102"));
        library.Add(new Book("Re:Zero", "Tappei Nagatsuki", "103"));
        library.Add(new Book("No Game No Life", "Yuu Kamiya", "104"));
        library.Add(new Book("Classroom of the Elite", "Shougo Kinugasa", "105"));


        library[3].BorrowBook();
        library[4].BorrowBook();


        foreach (Book b in library)
        {
            b.DisplayInfo();
        }
    }
}