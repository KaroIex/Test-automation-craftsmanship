namespace Lab2TDD;

public class Library
{
    public List<Book> Books { get; } = [];
    public List<Reader> Readers { get; } = [];

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public void AddReader(Reader reader)
    {
        Readers.Add(reader);
    }

    public void LendBook(Book book, Reader reader)
    {
        if (!Books.Contains(book) || !Readers.Contains(reader)) return;
        book.IsLent = true;
        book.Borrower = reader;
    }

    public void ReturnBook(Book book, Reader reader)
    {
        if (!book.IsLent || book.Borrower != reader) return;
        book.IsLent = false;
        book.Borrower = null;
        reader.ReturnBook(book);
    }

    public void RemoveReader(Reader reader)
    {
        if (!Readers.Contains(reader)) return;
        foreach (var book in reader.BorrowedBooks.ToList()) ReturnBook(book, reader);
        Readers.Remove(reader);
    }
}