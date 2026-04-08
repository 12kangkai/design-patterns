namespace CommandDemo.Simple;

public class PlayerInvoker
{
    private ICommand? _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command?.Execute();
    }
}
