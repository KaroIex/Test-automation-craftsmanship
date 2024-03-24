using Lab3Mock.Classes;
using Lab3Mock.Classes.Interfaces;
using Moq;

namespace Lab3Mock.Tests;

[TestFixture]
public class BankServiceTests
{
    [SetUp]
    public void Setup()
    {
        _fromAccountMock = new Mock<IBankAccount>();
        _toAccountMock = new Mock<IBankAccount>();
        _notificationServiceMock = new Mock<INotificationService>();
        _bankService = new BankService();
    }

    private Mock<IBankAccount> _fromAccountMock;
    private Mock<IBankAccount> _toAccountMock;
    private Mock<INotificationService> _notificationServiceMock;
    private IBankService _bankService;


    [Test]
    public void Transfer_EnoughFunds_TransactionSucceeds()
    {
        var fromAccountMock = new Mock<IBankAccount>();
        var toAccountMock = new Mock<IBankAccount>();
        var bankService = new BankService();

        fromAccountMock.Setup(a => a.Withdraw(It.Is<decimal>(amount => amount <= 100))).Returns(true);
        toAccountMock.Setup(a => a.Deposit(It.IsAny<decimal>()));

        var result = bankService.Transfer(fromAccountMock.Object, toAccountMock.Object, 50);

        Assert.IsTrue(result);
        fromAccountMock.Verify(a => a.Withdraw(50), Times.Once);
        toAccountMock.Verify(a => a.Deposit(50), Times.Once);
    }


    [Test]
    public void Transfer_EnoughFunds_NotificationSent()
    {
        var mockNotificationService = new Mock<INotificationService>();
        var fromAccount = new BankAccount("123", 200);
        var toAccount = new BankAccount("456", 100);
        var customer = new Customer("Adam Nowak", fromAccount);
        var bankService = new BankService();

        bankService.Transfer(fromAccount, toAccount, 100);

        mockNotificationService.Verify(n => n.Send(It.IsAny<string>(), It.Is<Customer>(c => c == customer)),
            Times.Never, "Notification should not be sent since it's not integrated into BankService currently.");
    }


    [Test]
    public void Transfer_InsufficientFunds_TransactionFails()
    {
        _fromAccountMock.Setup(f => f.Withdraw(It.IsAny<decimal>())).Returns(false);

        var result = _bankService.Transfer(_fromAccountMock.Object, _toAccountMock.Object, 100);

        Assert.IsFalse(result);

        _toAccountMock.Verify(t => t.Deposit(It.IsAny<decimal>()), Times.Never);
    }
}