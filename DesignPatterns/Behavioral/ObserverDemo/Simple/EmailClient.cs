namespace ObserverDemo.Simple;

public class EmailClient : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"[邮件订阅] 收到新闻：{message}");
    }
}
