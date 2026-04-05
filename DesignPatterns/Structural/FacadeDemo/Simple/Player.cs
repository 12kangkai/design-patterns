namespace FacadeDemo.Simple;

public class Player
{
    public void On()
    {
        Console.WriteLine("播放器开启");
    }

    public void Play(string movie)
    {
        Console.WriteLine($"开始播放：{movie}");
    }
}
