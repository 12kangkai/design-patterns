namespace CommandDemo.Simple;

public class NextTrackCommand : ICommand
{
    private readonly Player _player;

    public NextTrackCommand(Player player)
    {
        _player = player;
    }

    public void Execute()
    {
        _player.NextTrack();
    }
}
