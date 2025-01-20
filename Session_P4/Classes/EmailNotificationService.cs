using TaskSession_P4.Interfaces;

namespace TaskSession_P4.Classes;

public class EmailNotificationService:INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"Email=> recipient: {recipient}, message: {message}");
    }
}