namespace FacadeDemo.Simple;

public class HomeTheaterFacade
{
    private readonly LightSystem _lightSystem;
    private readonly Projector _projector;
    private readonly Player _player;

    public HomeTheaterFacade(LightSystem lightSystem, Projector projector, Player player)
    {
        _lightSystem = lightSystem;
        _projector = projector;
        _player = player;
    }

    public void WatchMovie(string movie)
    {
        _lightSystem.Dim();
        _projector.On();
        _player.On();
        _player.Play(movie);
    }
}
