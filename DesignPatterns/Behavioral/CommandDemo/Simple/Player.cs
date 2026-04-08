namespace CommandDemo.Simple;

public class Player
{
    public void Play()
    {
        Console.WriteLine("播放器：开始播放");
    }

    public void Pause()
    {
        Console.WriteLine("播放器：暂停播放");
    }

    public void NextTrack()
    {
        Console.WriteLine("播放器：切换下一首");
    }
}
