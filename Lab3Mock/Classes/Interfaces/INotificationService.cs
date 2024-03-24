namespace Lab3Mock.Classes.Interfaces;

public interface INotificationService
{
    void Send(string message, Customer customer);
}