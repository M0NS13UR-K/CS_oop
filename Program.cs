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
