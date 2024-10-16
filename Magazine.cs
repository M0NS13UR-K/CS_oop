public class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }
    
    // Override ShowDetails to display magazine-specific details
    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine($"Issue Number: {IssueNumber}");
    }
}
