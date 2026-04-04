namespace BuilderDemo.Simple;

public class Computer
{
    public string CPU { get; set; }
    public string Disk { get; set; }
    public string Memory { get; set; }
    public string OS { get; set; }

    public void ShowConfig()
    {
        Console.WriteLine($"CPU:{CPU}");
        Console.WriteLine($"Disk:{Disk}");
        Console.WriteLine($"Memory:{Memory}");
        Console.WriteLine($"OS:{OS}");
    }
}
