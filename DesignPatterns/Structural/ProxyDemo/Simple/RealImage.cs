namespace ProxyDemo.Simple;

public class RealImage : IImage
{
    private readonly string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"加载图片文件：{_fileName}");
    }
    
    public void Display()
    {
        Console.WriteLine($"显示图片：{_fileName}");
    }
}
