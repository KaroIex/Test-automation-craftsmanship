namespace Lab3Mock.Classes.Interfaces;

public interface ITransaction
{
    decimal Amount { get; }
    DateTime Date { get; }
    string Description { get; }
}