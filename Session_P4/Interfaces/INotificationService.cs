namespace TaskSession_P4.Interfaces;

public interface INotificationService
{
    public void SendNotification(string recipient, string message);
}