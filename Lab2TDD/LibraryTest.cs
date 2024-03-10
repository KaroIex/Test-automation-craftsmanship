using static NUnit.Framework.Assert;

namespace Lab2TDD;

[TestFixture]
public class LibraryTests
{
    private Library _library;

    [SetUp]
    public void SetUp()
    {
        _library = new();
    }
    [Test]
    public void AddReader_ShouldAddReaderToLibrary()
    {
        // Arrange
        var reader = new Reader("Jan Kowalski");

        // Act
        _library.AddReader(reader);

        // Assert
        Contains(reader, _library.Readers);
    }

    [Test]
    public void AddBook_ShouldAddBookToLibrary()
    {
        // Arrange
        var book = new Book("W pustyni i w puszczy", "Henryk Sienkiewicz");

        // Act
        _library.AddBook(book);

        // Assert
        Contains(book, _library.Books);
    }

    [Test]
    public void LendBook_ShouldLendBookToReader()
    {
        // Arrange
        var reader = new Reader("Anna Nowak");
        var book = new Book("Lalka", "Bolesław Prus");
        _library.AddReader(reader);
        _library.AddBook(book);

        // Act
        _library.LendBook(book, reader);

        // Assert
        IsTrue(book.IsLent);
        AreEqual(reader, book.Borrower);
    }

    [Test]
    public void ReturnBook_ShouldReturnBookToLibrary()
    {
        // Arrange
        var reader = new Reader("Juliusz Słowacki");
        var book = new Book("Pan Tadeusz", "Adam Mickiewicz");
        _library.AddReader(reader);
        _library.AddBook(book);
        _library.LendBook(book, reader);

        // Act
        _library.ReturnBook(book, reader);

        // Assert
        IsFalse(book.IsLent);
        IsNull(book.Borrower);
        IsFalse(reader.BorrowedBooks.Contains(book));
    }
}