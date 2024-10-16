public class Book : LibraryItem
{
    public string Author { get; set; }
    public string ISBN { get; set; }
    public bool IsAvailable { get; set; } = true;  // Encapsulation: Book availability
    
    // Override ShowDetails to display book-specific details
    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine($"Author: {Author}, ISBN: {ISBN}, Available: {IsAvailable}");
    }

    // Encapsulated methods to manage borrowing and returning the book
    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"{Title} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"{Title} is currently unavailable.");
        }
    }

    public void ReturnBook()
    {
        IsAvailable = true;
        Console.WriteLine($"{Title} has been returned.");
    }
}

