namespace FactoryMethodDemo.Simple;

public class FileLoggerFactory : LoggerFactory
{
    protected override ILogger CreateLogger()
    {
        return new FileLogger();
    }
}
