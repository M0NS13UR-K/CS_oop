public class LibraryItem
{
    public string Title { get; set; }
    public string Publisher { get; set; }
    
    // Virtual method to allow overriding
    public virtual void ShowDetails()
    {
        Console.WriteLine($"Title: {Title}, Publisher: {Publisher}");
    }
}

public class Library
{
    private List<LibraryItem> items = new List<LibraryItem>();  // Encapsulation: private collection

    // Method to add an item to the library
    public void AddItem(LibraryItem item)
    {
        items.Add(item);
        Console.WriteLine($"{item.Title} added to the library.");
    }

    // Method to list all items in the library
    public void ListItems()
    {
        foreach (var item in items)
        {
            item.ShowDetails();
            Console.WriteLine();  // Blank line for readability
        }
    }
}
public abstract class LibraryUser
{
    public string Name { get; set; }

    // Abstract method forces derived classes to implement borrowing behavior
    public abstract void BorrowBook(Book book);
}

public interface ILibraryActions
{
    void Borrow(Book book);
    void Return(Book book);
}

public class Member : LibraryUser, ILibraryActions
{
    // Implement abstract method for borrowing books
    public override void BorrowBook(Book book)
    {
        if (book.IsAvailable)
        {
            book.BorrowBook();
        }
        else
        {
            Console.WriteLine($"{book.Title} is unavailable for borrowing.");
        }
    }

    // Implement interface methods for borrowing and returning
    public void Borrow(Book book)
    {
        BorrowBook(book);  // Calls the abstract method implementation
    }

    public void Return(Book book)
    {
        book.ReturnBook();
    }
}
