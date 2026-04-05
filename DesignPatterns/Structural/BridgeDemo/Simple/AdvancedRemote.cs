namespace BridgeDemo.Simple;

public class AdvancedRemote : RemoteControl
{
    public AdvancedRemote(IDevice device) : base(device)
    {
    }

    public void Mute()
    {
        _device.SetVolume(0);
    }
}
