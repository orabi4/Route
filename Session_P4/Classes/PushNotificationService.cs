using TaskSession_P4.Interfaces;

namespace TaskSession_P4.Classes;

public class PushNotificationService:INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"Push Notification=> recipient: {recipient}, message: {message}");
    }
}