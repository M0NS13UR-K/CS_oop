class Program
{
    static void Main(string[] args)
    {
        // Create a library
        Library library = new Library();

        // Create books and magazines
        Book book1 = new Book { Title = "C# in Depth", Author = "Jon Skeet", Publisher = "Manning", ISBN = "12345" };
        Book book2 = new Book { Title = "Clean Code", Author = "Robert C. Martin", Publisher = "Prentice Hall", ISBN = "67890" };
        Magazine magazine1 = new Magazine { Title = "Tech Monthly", Publisher = "Tech Publishers", IssueNumber = 42 };

        // Add items to the library
        library.AddItem(book1);
        library.AddItem(book2);
        library.AddItem(magazine1);

        // List library items
        library.ListItems();

        // Create a library member
        Member member = new Member { Name = "Alice" };

        // Borrow and return books
        member.Borrow(book1);
        member.Borrow(book2);
        member.Return(book1);

        // List library items again to see the status
        library.ListItems();
    }
}
