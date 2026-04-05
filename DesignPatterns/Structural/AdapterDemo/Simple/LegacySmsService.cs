namespace AdapterDemo.Simple;

/// <summary>
/// 被适配者（旧系统接口）
/// </summary>
public class LegacySmsService
{
    public void SendSms(string content)
    {
        Console.WriteLine($"旧短信接口发送:{content}");
    }
}
