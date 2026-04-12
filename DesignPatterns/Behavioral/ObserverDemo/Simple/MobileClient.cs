namespace ObserverDemo.Simple;

public class MobileClient : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"[手机订阅] 收到新闻：{message}");
    }
}
