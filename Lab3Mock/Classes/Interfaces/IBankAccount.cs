namespace Lab3Mock.Classes.Interfaces;

public interface IBankAccount
{
    string AccountNumber { get; }
    decimal Balance { get; }
    void Deposit(decimal amount);
    bool Withdraw(decimal amount);
}