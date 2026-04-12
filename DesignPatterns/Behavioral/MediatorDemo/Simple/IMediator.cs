namespace MediatorDemo.Simple;

public interface IMediator
{
    void Notify(object sender, string eventCode);
}
