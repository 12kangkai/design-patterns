namespace BridgeDemo.Simple;

public class Radio : IDevice
{
    public void On()
    {
        Console.WriteLine("Radio On");
    }

    public void Off()
    {
        Console.WriteLine("Radio Off");
    }

    public void SetVolume(int percent)
    {
        Console.WriteLine($"Radio SetVolume: {percent}");
    }
}
