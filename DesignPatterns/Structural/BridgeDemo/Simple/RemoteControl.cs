namespace BridgeDemo.Simple;

public abstract class RemoteControl
{
    protected IDevice _device;
    
    protected  RemoteControl(IDevice device)
    {
        _device = device;
    }

    public virtual void TogglePower()
    {
        _device.On();
    }
    
    public void VolumeUp()
    {
        _device.SetVolume(10);
    }
   
    
}
