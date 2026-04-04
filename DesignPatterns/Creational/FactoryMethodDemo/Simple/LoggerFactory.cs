namespace FactoryMethodDemo.Simple;

public abstract class LoggerFactory
{
    protected abstract ILogger CreateLogger();

    public void Log(string message)
    {
        var logger = CreateLogger();
        logger.Write(message);
    }
}
