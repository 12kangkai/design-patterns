namespace BridgeDemo.Simple;

public class TV : IDevice
{
    public void On()
    {
        Console.WriteLine("TV On");
    }

    public void Off()
    {
        Console.WriteLine("TV Off");
    }

    public void SetVolume(int percent)
    {
        Console.WriteLine($"TV SetVolume: {percent}");
    }
}
