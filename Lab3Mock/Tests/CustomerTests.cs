using Lab3Mock.Classes;
using Lab3Mock.Classes.Interfaces;
using Moq;

namespace Lab3Mock.Tests;

[TestFixture]
public class NotificationServiceTests
{
    [SetUp]
    public void Setup()
    {
        _bankAccountMock = new Mock<IBankAccount>();
        _customer = new Customer("Adam Nowak", _bankAccountMock.Object);
    }

    private Mock<IBankAccount> _bankAccountMock;
    private ICustomer _customer;

    [Test]
    public void Customer_DepositToAccount_DepositMethodCalled()
    {
        var depositAmount = 100m;

        _customer.Account.Deposit(depositAmount);

        _bankAccountMock.Verify(x => x.Deposit(depositAmount), Times.Once);
    }

    [Test]
    public void Customer_WithdrawFromAccount_WithdrawMethodCalled()
    {
        var withdrawAmount = 50m;
        _bankAccountMock.Setup(x => x.Withdraw(It.IsAny<decimal>())).Returns(true);

        var result = _customer.Account.Withdraw(withdrawAmount);

        _bankAccountMock.Verify(x => x.Withdraw(withdrawAmount), Times.Once);
        Assert.IsTrue(result);
    }
}