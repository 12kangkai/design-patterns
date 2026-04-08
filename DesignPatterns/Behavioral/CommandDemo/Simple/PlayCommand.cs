namespace CommandDemo.Simple;

public class PlayCommand : ICommand
{
    private readonly Player _player;

    public PlayCommand(Player player)
    {
        _player = player;
    }

    public void Execute()
    {
        _player.Play();
    }
}
