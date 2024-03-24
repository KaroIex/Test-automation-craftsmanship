using Lab3Mock.Classes;
using Lab3Mock.Classes.Interfaces;

namespace Lab3Mock.Tests;

[TestFixture]
public class BankAccountTests
{

    [Test]
    public void Deposit_PositiveAmount_BalancesIncreases()
    {
        var account = new BankAccount("123", 100);
        account.Deposit(50);
        Assert.That(account.Balance, Is.EqualTo(150));
    }

    [Test]
    public void Withdraw_AmountGreaterThanBalance_ReturnsFalse()
    {
        var account = new BankAccount("123", 100);
        var result = account.Withdraw(150);
        Assert.IsFalse(result);
    }

    [Test]
    public void Withdraw_WithInsufficientFunds_ReturnsFalse()
    {
        var account = new BankAccount("123", 50);
        bool result = account.Withdraw(100);
        Assert.IsFalse(result);
    }

    [Test]
    public void Withdraw_WithExactFunds_ReturnsTrue()
    {
        var account = new BankAccount("123", 100);
        bool result = account.Withdraw(100);
        Assert.IsTrue(result);
    }

    [Test]
    public void Deposit_NegativeAmount_ThrowsArgumentException()
    {
        var account = new BankAccount("123", 100);
        Assert.Throws<ArgumentException>(() => account.Deposit(-50));
    }

}