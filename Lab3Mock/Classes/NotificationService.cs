using Lab3Mock.Classes.Interfaces;

namespace Lab3Mock.Classes;

public class NotificationService : INotificationService
{
    public void Send(string message, Customer customer)
    {
        Console.WriteLine($"Sending '{message}' to {customer.Name}");
    }
}