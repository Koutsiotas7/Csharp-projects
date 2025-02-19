using System;
using System.Collections.Generic;

public class BookLibrary
{
    // List to hold the books
    private List<Book> books = new List<Book>();

    // Method to add a new book
    public void AddBook(string title, string author, string genre)
    {
        Book book = new Book(title, author, genre);
        books.Add(book);
        Console.WriteLine("Book added successfully!");
    }

    // Method to display all books in the library
    public void DisplayBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books in the library.");
        }
        else
        {
            Console.WriteLine("\nBooks in Library:");
            foreach (var book in books)
            {
                book.DisplayBookInfo();
            }
        }
    }

    // Method to remove a book by title
    public void RemoveBook(string title)
    {
        var bookToRemove = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine($"Book '{title}' removed successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
}
