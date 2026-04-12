namespace ObserverDemo.Simple;

public class NewsPublisher : ISubject
{
    private readonly List<IObserver> _observers = new();
    private string _news;
    
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_news);
        }
    }
    
    public void PublishNews(string news)
    {
        _news = news;
        Console.WriteLine($"发布新闻：{_news}");
        Notify();
    }
}
