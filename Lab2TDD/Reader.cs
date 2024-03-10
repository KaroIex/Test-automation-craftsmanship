namespace Lab2TDD;

public class Reader(string name)
{
    public string Name { get; private set; } = name;
    public List<Book> BorrowedBooks { get; } = [];

    public void BorrowBook(Book book)
    {
        BorrowedBooks.Add(book);
    }

    public void ReturnBook(Book book)
    {
        BorrowedBooks.Remove(book);
    }
}