namespace FactoryMethodDemo.Simple;

public class FileLogger : ILogger
{
    public void Write(string message)
    {
        Console.WriteLine($"{DateTime.Now} 写入文件日志: {message}");
    }
}
