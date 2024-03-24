using Lab3Mock.Classes.Interfaces;

namespace Lab3Mock.Classes;

public class Transaction(decimal amount, DateTime date, string description) : ITransaction
{
    public decimal Amount { get; } = amount;
    public DateTime Date { get; } = date;
    public string Description { get; } = description;
}