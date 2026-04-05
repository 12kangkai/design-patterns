namespace AdapterDemo.Simple;

/// <summary>
/// 适配器
/// </summary>
public class SmsAdapter : INotification
{
    private readonly LegacySmsService _legacySmsService;

    public SmsAdapter(LegacySmsService legacySmsService)
    {
        _legacySmsService = legacySmsService;
    }

    public void Send(string message)
    {
        _legacySmsService.SendSms(message);
    }
}
