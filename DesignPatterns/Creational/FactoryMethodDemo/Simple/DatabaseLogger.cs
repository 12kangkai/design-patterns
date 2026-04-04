namespace FactoryMethodDemo.Simple;

public class DatabaseLogger : ILogger
{
    public void Write(string message)
    {
        Console.WriteLine($"{DateTime.Now} 写入数据库日志: {message}");
    }
}
