namespace AdapterDemo.Simple;

/// <summary>
/// 客户端
/// </summary>
public class MessageClinet
{
    private readonly INotification _notification;

    public MessageClinet(INotification notification)
    {
        _notification = notification;
    }

    public void Notify(string message)
    {
        _notification.Send(message);
    }
    
}
