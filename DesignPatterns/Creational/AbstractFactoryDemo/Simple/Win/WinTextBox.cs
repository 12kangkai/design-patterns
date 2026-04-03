namespace AbstractFactoryDemo.Simple.Win;

public class WinTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("WinTextBox Render");
    }
}
