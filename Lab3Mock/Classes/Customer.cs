using Lab3Mock.Classes.Interfaces;

namespace Lab3Mock.Classes;

public class Customer(string name, IBankAccount account) : ICustomer
{
    public string Name { get; } = name;
    public IBankAccount Account { get; } = account;
}