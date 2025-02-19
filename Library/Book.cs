public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }

    // Constructor to initialize the book details
    public Book(string title, string author, string genre)
    {
        Title = title;
        Author = author;
        Genre = genre;
    }

    // Method to display book details
    public void DisplayBookInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Genre: {Genre}");
    }
}
