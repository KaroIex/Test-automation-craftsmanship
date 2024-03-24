using Lab3Mock.Classes.Interfaces;

namespace Lab3Mock.Classes;

public class BankService : IBankService
{
    public bool Transfer(IBankAccount fromAccount, IBankAccount toAccount, decimal amount)
    {
        if (!fromAccount.Withdraw(amount))
            return false;
        toAccount.Deposit(amount);
        return true;
    }
}