namespace ProxyDemo.Simple;

public class ImageProxy : IImage
{
    private readonly string _fileName;
    private RealImage? _realImage;
    
    public ImageProxy(string fileName)
    {
        _fileName = fileName;
    }
    
    public void Display()
    {
        if (_realImage is null)
        {
            _realImage = new RealImage(_fileName);
        }
        _realImage.Display();
    }
}
