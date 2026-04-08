namespace CommandDemo.Simple;

public class PauseCommand : ICommand
{
    private readonly Player _player;

    public PauseCommand(Player player)
    {
        _player = player;
    }
    
    public void Execute()
    {
        _player.Pause();
    }
}
