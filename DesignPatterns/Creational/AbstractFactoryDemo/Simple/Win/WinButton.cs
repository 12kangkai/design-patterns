namespace AbstractFactoryDemo.Simple.Win;

public class WinButton : IButton
{
    public void Render()
    {
        Console.WriteLine("WinButton Render");
    }
}
