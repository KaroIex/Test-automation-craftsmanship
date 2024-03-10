namespace Lab2TDD;

public class Book(string title, string author)
{
    public string Title { get; private set; } = title;
    public string Author { get; private set; } = author;
    public bool IsLent { get; set; } = false;
    public Reader Borrower { get; set; }
}