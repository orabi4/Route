using TaskSession_P4.Interfaces;

namespace TaskSession_P4.Classes;

public class SmsNotificationService: INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"SMS=> recipient: {recipient}, message: {message}");
    }
}