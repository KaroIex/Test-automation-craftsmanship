namespace Lab3Mock.Classes.Interfaces;

public interface ICustomer
{
    string Name { get; }
    IBankAccount Account { get; }
}