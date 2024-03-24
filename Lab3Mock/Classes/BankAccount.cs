using Lab3Mock.Classes.Interfaces;

namespace Lab3Mock.Classes;

public class BankAccount(string accountNumber, decimal initialBalance) : IBankAccount
{
    public string AccountNumber { get; } = accountNumber;
    public decimal Balance { get; private set; } = initialBalance;

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");
        Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
            return false;
        Balance -= amount;
        return true;
    }
}