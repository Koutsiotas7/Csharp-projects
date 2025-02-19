using System;

class Program
{
    static void Main(string[] args)
    {
        BookLibrary library = new BookLibrary();

        while (true)
        {
            // Display menu
            Console.WriteLine("\nLibrary Menu:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Remove Book");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter book genre: ");
                    string genre = Console.ReadLine();
                    library.AddBook(title, author, genre);
                    break;

                case "2":
                    library.DisplayBooks();
                    break;

                case "3":
                    Console.Write("Enter the title of the book to remove: ");
                    string bookToRemove = Console.ReadLine();
                    library.RemoveBook(bookToRemove);
                    break;

                case "4":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
