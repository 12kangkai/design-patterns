namespace FactoryMethodDemo.Simple;

public class DatabaseLoggerFactory : LoggerFactory
{
    protected override ILogger CreateLogger()
    {
        return new DatabaseLogger();
    }
}
